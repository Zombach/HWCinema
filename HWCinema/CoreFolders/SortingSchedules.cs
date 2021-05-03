using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCinema.CoreFolders
{
    public class SortingSchedules
    {
        private Core _core = Core.GetCore();
        public List<FilmData> SortFilms { get; set; }
        public List<FilmData> TmpFilms { get; set; }
        public List<List<FilmData>> SchedulesFilms { get; set; }
        private List <Hall> _halls { get; set; }

        public SortingSchedules()
        {
            SortFilms = new List<FilmData>();
            SchedulesFilms = new List<List<FilmData>>();
            TmpFilms = new List<FilmData>();
            _halls = new List<Hall>();
            _halls.AddRange(_core.Halls);
        }

        public void PreparingSort()
        {
            foreach (Hall hall in _halls)
            {
                SortedEfficiency(hall);
            }
        }

        public void SortedEfficiency(Hall hall)
        {
            List <int> indexes = new List<int>();
            
            List<int> efficiency = new List<int>();
            efficiency.AddRange(hall.AllFreeTime);
            List<int> tmpAllFreeTime = new List<int>();
            tmpAllFreeTime.AddRange(hall.AllFreeTime);
            efficiency.Sort();
            foreach (int number in efficiency)
            {
                int index = tmpAllFreeTime.IndexOf(number);
                tmpAllFreeTime[index] = -1;
                indexes.Add(index);
            }

            foreach (int index in indexes)
            {
                SchedulesFilms.Add(hall.GetScheduleFilms[index]);
            }
            hall.SetSort = SchedulesFilms;
            hall.AllFreeTime_Sort = efficiency;
        }

        

        public void Sorting(Hall hall, bool repeat = false, bool priority = false, bool once = false)
        {
            if(repeat)
            {

            }
            if(priority)
            {

            }
            if(once)
            {
                Sort_ShowAllOnce_OneHall(hall);
            }
        }

        private void Sort_ShowAllOnce_OneHall(Hall hall)
        {
            foreach (List<FilmData> films in hall.GetScheduleFilms)
            {
                foreach (FilmData film in films)
                {

                }
            }
            
        }
        private void Sort_ShowAllOnce_AllHalls(Hall hall)
        {

        }
        private void Sort_NoRepeat()
        {
            TmpFilms = new List<FilmData>();

        }

        private void Sort_Priority()
        {

        }

        

        private void Sort_()
        {

        }
        private void Sort_2()
        {

        }
    }
}
