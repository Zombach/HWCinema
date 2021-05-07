using System.Collections.Generic;

namespace HWCinema.CoreFolders
{
    public class Core
    {
        private static Core _core;
        public string MyPathSettings { get; set; }
        public List <Hall> Halls { get; set; }
        public List<FilmData> Films { get; set; }
        public List<FilmData> FilmTmp { get; set; }

        private Core()
        {
            Halls = new List<Hall>();
            Films = new List<FilmData>();
            FilmTmp = new List<FilmData>();
            MyPathSettings = @"../../Settings/Settings.txt";
        }

        public static Core GetCore()
        {
            if (_core == null)
            {
                _core = new Core();
            }
            return _core;
        }

        public void CreateSchedule()
        {
            for (int i = 0; i < Halls.Count; i++)
            {
                if (Halls[i].GetScheduleFilms != null)
                {
                    Halls[i].Clean_Schedule_Films();
                    Halls[i].Clean_FreeTime_Shcedule();
                }
                if (Halls[i].GetSortFilms != null)
                {
                    Halls[i].Clean_Schedule_Sort();
                    Halls[i].Clean_FreeTime_Sort();
                }
                TmpData tmpData = new TmpData(new List<FilmData>(), Halls[i].AllTimeWorkInMinutes);
                CreateGraph(Halls[i], tmpData);
            }
        }       

        private void CreateGraph(Hall hall, TmpData tmpData)
        {
            foreach (FilmData film in Films)
            {
                if(film.Time <= tmpData.Times)
                {
                    FilmTmp.Clear();
                    if (tmpData.Films != null)
                    {
                        FilmsCopy(tmpData);
                    }
                    FilmTmp.Add(film);
                    TmpData dataTmp = new TmpData(FilmTmp, tmpData.Times - film.Time);
                    CreateGraph(hall, dataTmp);
                }
            }
            WriteInHall(hall, tmpData);
        }
        private void FilmsCopy(TmpData tmpData)
        {
            foreach (FilmData films in tmpData.Films)
            {
                FilmTmp.Add(films);
            }
        }
        private void  WriteInHall(Hall hall, TmpData tmpData)
        {
            bool isLast = CheckLastElement(tmpData);
            if (isLast)
            {
                Write(hall, tmpData);
            }
        }
        private bool CheckLastElement(TmpData tmpData)
        {
            bool isLast = true;
            foreach (FilmData film in Films)
            {
                if (film.Time <= tmpData.Times)
                {
                    isLast = false;
                }
            }
            return isLast;
        }
        private void Write(Hall hall, TmpData tmpData)
        {
            hall.SetFilms = tmpData.Films;
            tmpData.Films.Clear();
            hall.AllFreeTime.Add(tmpData.Times);
        }        
    }
}
