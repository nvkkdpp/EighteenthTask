using System;

namespace EighteenthTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            AverageAndDisplay("Оценки 1", 3.5, "Оценки 2", 4.0);
            Console.WriteLine("Нажмите <Enter> Для завершения программы . . . ");
            Console.Read();
        }
        public static void AverageAndDisplay(string s1, double d1, string s2, double d2)
        {
            double average = (d1 + d2) / 2;
            Console.WriteLine(" Среднее " + s1 + " Равной " + d1 + ", и " + s2 + " Равной" + d2 + ", Равно " + average);
        }
    }
}
