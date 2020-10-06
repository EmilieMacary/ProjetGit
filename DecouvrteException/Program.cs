using System;

namespace DecouvrteException
{
    class EssaiException
    {
        static public int Parse(string numberString) => int.Parse(numberString);

        static public double Divide(double number1, double number2)
        {
            double result = number1 / number2;
            if (double.IsInfinity(result))
                throw new DivideByZeroException();
            return result;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Entrez votre premier nombre");
                string readString1 = Console.ReadLine();
                Console.WriteLine("Entrez votre deuxième nombre");
                string readString2 = Console.ReadLine();

                bool isNumber1Ok = int.TryParse(readString1, out int number1);
                if (!isNumber1Ok)
                {
                    Console.WriteLine($"{readString1} n'est pas un nombre !!!");
                    continue;
                }

                int number2;
                try
                {
                    number2 = int.Parse(readString2);
                }
                catch
                {
                    Console.WriteLine($"{readString2} n'est pas un nombre !!!");
                    continue;
                }
                Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Méthode 2");
                Console.WriteLine("Entrez votre premier nombre");
                string readString1 = Console.ReadLine();
                Console.WriteLine("Entrez votre deuxième nombre");
                string readString2 = Console.ReadLine();


                double number1;
                double number2;
                double result;
                try
                {
                    number1 = EssaiException.Parse(readString1);
                    number2 = EssaiException.Parse(readString2);
                    result = EssaiException.Divide(number1, number2);
                    Console.WriteLine($"{number1} / {number2} = {result}");
                    Console.WriteLine("opération ok");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"FormatException {readString1} ou {readString2} n'est pas un nombre");
                    Console.WriteLine($"Exeption : {ex.GetType()} message : {ex.Message} trace : {ex.StackTrace}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"DivideByZeroException votre deuxième nombre est égal à 0 !!!");
                    Console.WriteLine($"Exeption : {ex.GetType()} message : {ex.Message} trace : {ex.StackTrace}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Autre exception : {ex.GetType()}");
                }
            }

        }
    }
}
