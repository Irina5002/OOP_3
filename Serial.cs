using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Serial : Info
    {
        public Serial(int a, int b, int c, int d, int e) : base(a)
        {
            film = b;
            score = c;
            genre = d;
            series = e;
        }
        public override string Output()
        {
            return "Сериал: " + film.ToString() + " Оценка: " + score.ToString() + " Жанр: " + genre.ToString() + " Серии: " + series.ToString();
        }
    }
}
