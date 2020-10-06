using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}, Age=20},
                new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}, Age=21},
                new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}, Age=22},
                new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}, Age=23},
                new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}, Age=24},
                new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}, Age=25},
                new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}, Age=32},
                new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}, Age=42},
                new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}, Age=35},
                new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}, Age=36},
                new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}, Age=38},
                new Student {First="Eugenie", Last="Zabok", ID=123, Scores= new List<int> {25, 28, 12, 15}, Age=31},
                new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}, Age=39},
                new Student {First="Claire", Last="Bidet", ID=124, Scores= new List<int> {94, 92, 91, 91}, Age=42},
                new Student {First="Claire", Last="Aragon", ID=125, Scores= new List<int> {94, 92, 91, 91}, Age=44},
            };

            // methode old school
            var notreSelection = new List<List<int>>();
            foreach (var student in students)
            {
                if (student.ID > 116 && student.Last == "Garcia")
                {
                    notreSelection.Add(student.Scores);
                }
            }

            //methodes linq "objects"
            List<Student> studentsSup116 = students.Where(s => s.ID > 116 && s.Last == "Garcia").ToList();
            var studentsIds = students.Where(s => s.ID > 116 && s.Last == "Garcia").Select(s => s.Scores).ToList();

            // methodes linq "sql like"

            var resultLinqSqlLike = from s in students
                                    where s.ID > 116 && s.Last == "Garcia"
                                    select s.Scores;

            resultLinqSqlLike.ToList();


            // var resultStudentMean = from s in students
            //                         select s.Scores.Average;

            List<double> ScoreAverage = new List<double>();

            foreach (var student in students)
            {
                var resultStudentAverage = student.Scores.Average();
                ScoreAverage.Add(resultStudentAverage);
            }

            var StudentAverage = students.Select(s => s.Scores.Average()).ToList();


            (int val1, string val2, bool val3) monTuple = (33, "toto", true);

            var StudentIDAverage = students.Select(s => new { id = s.ID, name = s.First, moy = s.Scores.Average() }).ToList();

            int studentId = StudentIDAverage[3].id;


            //Récupérer les trois premiers étudiants qui ont la moyenne la plus grande avec leur moyenne

            var studentList = students.Take(3).ToList();
            var studentMean = students.OrderByDescending(s => s.Scores.Average()).Take(3).ToList();

            var studentMeanList = students.Select(s => new { id = s.ID, name = s.First, moy = s.Scores.Average() }).OrderByDescending(x => x.moy).Take(3).ToList();

            // les trois etudiants qui possedent les notes les plus basses
            var studentWithMinScore = students.Select(s => new { id = s.ID, name = s.First, min = s.Scores.Min() }).OrderBy(x => x.min).Take(3).ToList();

            // les trois premiers etudiants dans l'ordre alphabetique
            var studentWithMinName = students.Select(s => new { id = s.ID, name = s.First, min = s.First.Min() }).OrderBy(x => x.min).Take(3).ToList();

            // les etudiants par ordre alphabétique des prénoms
            var studentWithName = students.OrderBy(x => x.First).ToList();

            // classement par ordre alphabetique des prénoms puis des noms
            var studentWithFisrtNameLastName = students.OrderBy(x => x.First).ThenBy(x => x.Last).ToList();

            // nombre d'étudiant par tranche d'ages

            //var studentListAge = students.Count(s => s.Age/10 * 10).ToList();

            var studentAge = students.GroupBy(s => s.Age / 10 * 10).ToList();

            // tous les etudiants qui sont trentenaires
            var studentAge30 = students.GroupBy(s => s.Age / 10 * 10).Where(x => x.Key == 30).ToList();

            var StudentMajor = students[3].IsMajorWithTuple();

            Student student1 = new Student
            {
                First = "Mickael"
            };

            StudentStruct student2 = new StudentStruct
            {
                First = "Mickael"
            };

            FunctionParametersClass(student1);
            FunctionParametersStruc(student2);

            ColorEnum maCouleur = (ColorEnum)10;
        }

        static void FunctionParametersClass(Student student)
        {
            student.First = "Toto";
        }

        static void FunctionParametersStruc(StudentStruct student)
        {
            student.First = "Toto";
        }
    }
}
