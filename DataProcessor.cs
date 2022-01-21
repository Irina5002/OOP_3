using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class DataProcessor <T> where T : Info
    {
        public List<T> list;
        public int x; //нижний порог отбора
        public int y; //верхний порог отбора

        public DataProcessor(List<T> list) //конструктор
        {
            this.list = list;
        }

        public void Select(int x, int y) 
        {
            if (x > y) throw new Exception("Неверное указывание диапозона");//создание ошибки

            var massForTask1 = from i in list
                               where (i.score >= x) && (i.score < y)
                               orderby i.score ascending
                               select i;

            var massForTask2 = massForTask1.Take(3); 

            foreach (Info i in massForTask2)
            {
                Console.WriteLine(i.Output());
            }
        }

        public void Search(int scoreInput) //поиск задачи по трудазатратности на неё (time - трудозатротность)
        {
            var output = from i in list
                         where i.score == scoreInput
                         select i;

            if (output.Count() == 0) throw new Exception("Фильма с данной оценкой нет");


            foreach (Info i in output)
            {
                Console.WriteLine(i.Output());
            }

        }
    }
}
