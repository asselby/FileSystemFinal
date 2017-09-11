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
            FileInfo file = new FileInfo(path);

            //int A = 12;
            //int B = 13;
            int sumOfAB;
            //using (StreamWriter writer = File.CreateText(path))
            //{
            //    writer.Write(A);
            //    writer.Write(" ");
            //    writer.Write(B);
            //}
                 
            // чтение из файла
            using (FileStream fstream = File.OpenRead(path))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                int textFromFile = System.Text.Encoding.Default.
                Console.WriteLine("Текст из файла: {0}", textFromFile);
          
            }

            Console.ReadLine();
   
        }
    }
}