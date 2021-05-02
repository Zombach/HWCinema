using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWCinema.CoreFolders
{
    public class Node
    {
        private Core _core = Core.GetCore();
        public static List<FilmData> Films;
        public Hall Hall { get; set; }
        public string NameHall { get; set; }
        public int[] FreeTime { get; set; }
        public FilmData Film { get; set; }
        /// <summary>
        /// Ссылки на следующий фильм если он есть
        /// </summary>
        public List<Node> Next { get; set; }
        /// <summary>
        /// Оставшиеся фильмы для следующих вариаций показов
        /// </summary>
        public List<FilmData> CurrentFilm { get; set; }



        public Node()
        {
            Hall = null;
            NameHall = null;
            FreeTime = new int[_core.FreeTime.Length];
            Film = null;
            Next = new List<Node>();
            CurrentFilm = new List<FilmData>();
        }

        public Node(int freeTime, List<FilmData> currentFilm = null, string nameHall = null, FilmData film = null)
        {
            if (FreeTime == null)
            {
                FreeTime = new int[1];
            }
            FreeTime[0] = freeTime;

            if (currentFilm != null)
            {
                CurrentFilm = currentFilm;
            }
            else
            {
                CurrentFilm = new List<FilmData>();
            }

            Next = new List<Node>();
            Film = film;
            NameHall = nameHall;
        }

        public void CreateSchedule(int test = 200)
        {
            //for (int i = 0; i < _core.Halls.Count; i++)
            //{
            //    CreateGraph(_core.FreeTime[i]);
            //}
            CreateGraph(test);
        }


        public void CreateGraph(int freeTime)
        {
            foreach (FilmData film in Films)
            {
                _core.FilmsTmp = new List<FilmData>();
                foreach (FilmData filmData in _core.FilmsCurrent)
                {
                    _core.FilmsTmp.Add(new FilmData(filmData.Name, filmData.Time, filmData.IsPriority));
                }
                _core.FilmsTmp.Add(new FilmData(film.Name, film.Time, film.IsPriority));
                freeTime -= film.Time;
                Node node = new Node(freeTime, _core.FilmsTmp);
                Next.Add(node);
                node.CreateGraph(freeTime);
            }
        }

        //public void CreateSchedules()
        //{
        //            ScheduleData schedule = new ScheduleData(_core.Halls[0], film, film, _core.FreeTime, _core.FreeTime[0], tmp);
        //            Next.Add(schedule);
        //            schedule.CreateSchedules();

        //}

        private string[] test = new string[] { "", "", "" };
        private List<string> test3 = new List<string>();
        public static List<List<string>> test2 = new List<List<string>>();
        public void WriteAllEnds()
        {
            if (Next.Count == 0)
            {
                foreach (FilmData film in CurrentFilm)
                {
                    test[0] +=(film.Name + " ");
                    test[1] += (film.Time + " ");
                }
                test3.Add(test[0]);
                test3.Add(test[1]);
            }
            else
            {
                foreach (Node data in Next)
                {
                    data.WriteAllEnds();
                }
            }
            if (test3.Count != 0)
            {
                test2.Add(test3);
            }
        }

        public List<List<string>> Test2()
        {
            return test2;
        }
    }
}
