using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Engin", "Berra", "Furkan" };



            string[] students2 = { "Engin", "Berra", "Furkan" };



            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                { "İstabul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale"},
                {"Adana","Mersin","Antalya"},
                {"Rize","Trabzon","Mersin"},
                {"izmir","Muğla","Manisa"},

            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);

                }
                Console.WriteLine("*********");


            }

            Console.ReadLine();
        }
    }
}
