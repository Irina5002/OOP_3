using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Info> watch = new List<Info>()
            {
                new Movie(0, 1, 5, 1),
                new Movie(1, 5, 3, 1),
                new Movie(2, 17, 4, 2),
                new Movie(3, 31, 3, 4),
            };

            foreach (Movie i in watch)
            {
                Console.WriteLine(i.Output());
            }

            DataProcessor<Info> myList = new DataProcessor<Info>(watch);
            //Вывести фильмы, где оценка больше или равна x, но меньше y, отсортированные по увелечению оценки максимумом в 3 элемента
            Console.WriteLine("\nВведите два числа(x, y) диапозона: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            try
            {
                myList.Select(x, y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Сделать поиск по оценке
            Console.WriteLine("\nВведите оценку для поиска: ");
            int scoreInput = Convert.ToInt32(Console.ReadLine());

            try
            {
                myList.Search(scoreInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
