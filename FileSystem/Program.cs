/*1.	В файле записана непустая последовательность целых чисел, являющихся числами Фибоначчи.
 *  Приписать еще столько же чисел этой последовательности.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\root\filesystem.txt";
            string fibonacciNumber = "0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144,";
            string fibonacciNumberSecond =  "233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946" ;
            FileInfo file = new FileInfo(path);
            using (StreamWriter writer = File.CreateText(path))
            {
               
                writer.WriteLine(fibonacciNumber);
            }

            using (StreamWriter secondWriter = File.AppendText(path))
            {
                secondWriter.WriteLine(fibonacciNumberSecond);
            }
            using (StreamReader reader = File.OpenText(path))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    Console.Write(line);
                }
                Console.ReadLine();
            }
        }
    }
}
