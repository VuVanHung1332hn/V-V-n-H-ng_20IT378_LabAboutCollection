using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LabAbouutCollection02
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap day so ban can tinh toan:");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int currentResult = numbers[i] + numbers[numbers.Count - 1 - i];
                result.Add(currentResult);
            }
            if (numbers.Count % 2 == 1)
            {
                result.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine("Ket qua cua day so ban da nhap:");
            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }
    }
}
