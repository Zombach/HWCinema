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
        public List<List<int>> _tmpTime { get; set; }
        public int[,] Index_Repeat { get; set; }
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
                SchedulesFilms = new List<List<FilmData>>();
                TmpFilms = new List<FilmData>();
                SortFilms = new List<FilmData>();
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


        public void NextSorting(Hall hall, bool repeat = false, bool priority = false, bool once = false)
        {
            if (repeat)
            {

            }
            if (priority)
            {

            }
            if (once)
            {
                Sort_ShowAllOnce_OneHall(hall);
            }
        }
        public void HowToSort(bool repeat = false, bool priority = false, bool once = false)
        {
            //PreparingRepeatSort();

                //NextSorting(hall, repeat: true);
        }

        private void PreparingRepeatSort()
        {
            foreach (Hall hall in _halls)
            {
                _tmpTime.Add(hall.AllFreeTime_Sort);
            }

            Index_Repeat = new int[_tmpTime.Count,2];
            int tmpTime = _tmpTime[0][0];
            for (int i = 0; i < _tmpTime.Count; i++)
            {
                if (tmpTime > _tmpTime[i][0])
                {
                    tmpTime = _tmpTime[i][0];
                    i = -1;
                }
            }

            List<int> tmpIndex = new List<int>();
            for (int i = 0; i < _tmpTime.Count; i++)
            {
                if (tmpTime == _tmpTime[i][0])
                {
                    tmpIndex.Add(i);
                }
            }

            List<int> tmptmp = new List<int>();
            List<int> tmpNull = new List<int>();
            if (tmpIndex.Count == 1)
            {
                _tmpTime[tmpIndex[0]].RemoveAt(0);
            }
            else
            {
                for (int i = 0; i < tmpIndex.Count; i++)
                {
                    if (_tmpTime[tmpIndex[i]].Count > 1)
                    {
                        tmptmp.Add(_tmpTime[tmpIndex[i]][1]);
                    }
                    else
                    {
                        tmpNull.Add(i);
                    }
                }
            }






            //List<int> indexes = new List<int>();
            //_halls = new List<Hall>();
            //_halls.AddRange(_core.Halls);
            //List<int> tmpTime = new List<int>();
            //foreach (Hall hall in _halls)
            //{
            //    tmpTime.Add(hall.AllFreeTime_Sort[0]);
            //}
            //List<int> tmpTimeCopy = new List<int>();
            //tmpTimeCopy.AddRange(tmpTime);
            //tmpTime.Sort();
            //List<Hall> tmpHalls = new List<Hall>();
            //foreach (int time in tmpTime)
            //{
            //    int index = tmpTimeCopy.IndexOf(time);
            //    tmpTimeCopy[index] = -1;
            //    indexes.Add(index);
            //}
            //foreach (int index in indexes)
            //{
            //    tmpHalls.Add(_halls[index]);
            //}
            //_halls = new List<Hall>();
            //_halls.AddRange(tmpHalls);
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
