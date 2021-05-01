using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCinema.CoreFolders
{
    public class ScheduleData
    {
        public Hall Hall { get; set; }
        public FilmData Film { get; set; }
        public int TimeLeftWork { get; set; }


        public ScheduleData(Hall hall, FilmData film, int time)
        {
            Hall = hall;
            Film = film;
            TimeLeftWork = time;
        }
    }
}
