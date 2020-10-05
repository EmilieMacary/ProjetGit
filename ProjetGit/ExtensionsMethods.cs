using System;

namespace ProjetGit
{
    public static class ExtensionsMethods
    {
        public static string MonExtension(this Dog dog)
        {

            return $"Chien à afficher : {dog.Name} qui a {Math.Round((DateTime.Now - dog.BirthDate).TotalDays)} unité de temps";
        }

        public static int Round(this double number)
        {
            return (int)Math.Round(number);
        }

        public static int SumAndRound(this double number, double otherNumber)
        {
            return (int)Math.Round(number + otherNumber);
        }

        public static double Sum(this double number, double otherNumber)
        {
            return number + otherNumber;
        }

        public static double SameSum(this double number, double otherNumber) => number + otherNumber;
    }
}
