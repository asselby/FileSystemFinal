/*2.	Сложить два целых числа А и В.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SumOfTwoElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\root\Input.txt";
            string pathSecond = @"C:\root\Output.txt";
            FileInfo file = new FileInfo(path);
            int A = 12;
            int B = 13;
            int sumOfAB;
            int numberA;
            int numberB;
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    writer.Write(A);
                    writer.Write(B);
                }
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        numberA = reader.ReadInt32();
                        reader.PeekChar();
                        numberB = reader.ReadInt32();
                        sumOfAB = numberA + numberB;
                        Console.WriteLine("Певрое число - {0}, второе число - {1}. ", numberA, numberB);
                        using (BinaryWriter writerSum = new BinaryWriter(File.Open(pathSecond, FileMode.OpenOrCreate)))
                        {
                            writerSum.Write(sumOfAB);
                        }
                        using (BinaryReader readerSum = new BinaryReader(File.Open(pathSecond, FileMode.Open)))
                        {
                            Console.WriteLine("Сумма двух чисел - {0}.", readerSum.Read());
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
