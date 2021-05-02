using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWCinema.CoreFolders
{
    public class ScheduleData
    {
        private Core _core = Core.GetCore();
        public Hall Hall { get; set; }
        public FilmData Film { get; set; }
        public FilmData NextFilm { get; set; }
        public List<ScheduleData> Next { get; set; } = new List<ScheduleData>();
        public List<FilmData> CurrentFilm { get; set; } = new List<FilmData>();
        public int FreeTime { get; set; }
        public int[] TimeLeftWork { get; set; }        

        public ScheduleData(/*int freeTime, List<FilmData> currentFilms*/)
        {
            //FreeTime = freeTime;
            //CurrentFilm = currentFilms;
        }

        public ScheduleData(Hall hall, FilmData film, FilmData nextFilm, int[] timeLeftWork, int freeTime, List<FilmData> currentFilms = null)
        {
            Hall = hall;
            Film = film;
            NextFilm = nextFilm;
            TimeLeftWork = timeLeftWork;
            FreeTime = freeTime;
            if (currentFilms != null)
            {
                CurrentFilm = currentFilms;
            }
            else
            {
                CurrentFilm = new List<FilmData>();
            }
            Next = new List<ScheduleData>();
        }

        
        public void CreateSchedules()
        {
            //PreparingSchedules preparing = new PreparingSchedules();
            foreach (FilmData film in _core.Films)
            {
                    if (film.Time <= _core.FreeTime[0])
                    {
                        List<FilmData> tmp = new List<FilmData>();
                        foreach (FilmData filmData in _core.FilmsCurrent)
                        {
                            tmp.Add(filmData);
                        }
                        tmp.Add(film);
                        _core.FreeTime[0] -= film.Time;
                        ScheduleData schedule = new ScheduleData(_core.Halls[0], film, film, _core.FreeTime, _core.FreeTime[0], tmp);
                        Next.Add(schedule);
                        schedule.CreateSchedules();
                   
                }
            }
        }

        public void WriteSchedule()
        {
            if (Next.Count == 0)
            {
                foreach (FilmData film in CurrentFilm)
                {
                    _core.TmpTest += (film.Name + " ");
                }
                _core.TmpTest += '\n';
                MessageBox.Show(_core.TmpTest);
            }
            else
            {
                foreach (ScheduleData data in Next)
                {
                    //for (int i = 0; i < data.TimeLeftWork.Length; i++)
                    //{
                    //    _tmptest += data.TimeLeftWork[i] + " ";
                    //    _tmptest += data.Film.Name + " ";
                    //}
                    data.WriteSchedule();
                }
            }
        }

        public void Message()
        {
            MessageBox.Show(_core.TmpTest);
        }
    }
}
