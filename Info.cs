using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    abstract class Info
    {
        public int film;
        public int score;
        public int genre;
        public int id;
        public int series;
        public Info(int a) { id = a; }

        public abstract string Output();
    }
}
