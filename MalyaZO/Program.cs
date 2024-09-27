using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalyaZO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"input.txt";
            string path2 = @"output.txt";

            using (StreamWriter writer = new StreamWriter(path2))
            using (StreamReader reader = new StreamReader(path1))
            {
                // Считываем входные данные
                string[] input = reader.ReadLine().Split(' ');
                int M = int.Parse(input[0]);

                int N = int.Parse(input[1]);

                // Вычисляем сумму остатков
                long sum = 0;
                long F0 = 0;
                long F1 = 1;
                for (int i = 0; i < N; i++)
                {
                    sum += F0 % M; // Сначала добавляем остаток от деления F0 на M
                    long F = (F0 + F1) % M; // Вычисляем следующее число Фибоначчи
                    F0 = F1;          // Обновляем F0
                    F1 = F;           // Обновляем F1
                }

                // Выводим результат
                Console.WriteLine(sum);
                writer.WriteLine(sum);
                Console.ReadKey();

            }
        }
    }
}
