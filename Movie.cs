using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Movie : Info
    {
        public Movie(int a, int b, int c, int d) : base(a)
        {
            film = b;
            score = c;
            genre = d;
        }
        public override string Output()
        {
            return "Фильм: " + film.ToString() + " Оценка: " + score.ToString() + " Жанр: " + genre.ToString();
        }
    }
}
