using System;
using System.Globalization;

namespace SequentialStructureExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] part1 = Console.ReadLine().Split(" ");
            string[] part2 = Console.ReadLine().Split(" ");

            double totalPart1 = double.Parse(part1[1], CultureInfo.InvariantCulture) * double.Parse(part1[2], CultureInfo.InvariantCulture);
            double totalPart2 = double.Parse(part2[1], CultureInfo.InvariantCulture) * double.Parse(part2[2], CultureInfo.InvariantCulture);

            double totalPayment = totalPart1 + totalPart2;

            Console.WriteLine("VALOR A PAGAR: R$" + totalPayment.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}