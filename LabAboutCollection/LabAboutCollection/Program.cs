using System;
using System.Collections.Generic;
using System.Linq;

namespace LabAboutCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap day so ban can tinh toan:");
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int index = 0;
            while (index < list.Count - 1)
            {
                if (list[index] == list[index + 1])
                {
                    list[index] *= 2;
                    list.RemoveAt(index + 1);
                    if (index > 0)
                    {
                        index--;
                    }
                }
                else
                {
                    index++;
                }
            }
            Console.WriteLine("Ket qua cua day so ban da nhap:");
            Console.WriteLine(string.Join(" ", list));
            Console.ReadLine();
        }
    }
}
