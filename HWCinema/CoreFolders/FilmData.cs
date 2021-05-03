using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCinema.CoreFolders
{
    public class FilmData
    {
        /// <summary>
        /// Имя фильма
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Время которое идет фильм
        /// </summary>
        public int Time { get; set; }
        /// <summary>
        /// Приоритетный фильм
        /// </summary>
        public bool IsPriority { get; set; }
        /// <summary>
        /// Колличество повторов
        /// </summary>
        public int RepeatCount { get; set; }
        public bool RepeatOtherHalls { get; set; }

        public FilmData(FilmData film)
        {
            Name = film.Name;
            Time = film.Time;
            IsPriority = film.IsPriority;
            RepeatCount = film.RepeatCount;
            RepeatOtherHalls = film.RepeatOtherHalls;
    }
        public FilmData(string name, int time, bool isPriority = false)
        {
            Name = name;
            Time = time;
            IsPriority = isPriority;
            RepeatCount = 0;
            RepeatOtherHalls = false;
        }
    }
}
