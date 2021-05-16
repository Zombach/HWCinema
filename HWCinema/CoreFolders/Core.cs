using System.Collections.Generic;

namespace HWCinema.CoreFolders
{
    public class Core
    {
        private static Core _core;
        private int _id;
        public ScheduleAll ScheduleAll { get; set; }
        public TimeFreeAll TimeFreeAll { get; set; }
        public BoolFormSchedule BoolFormSchedule { get; set; }
        public string MyPathSettings { get; set; }
        public List <Hall> Halls { get; set; }
        public List<FilmData> Films { get; set; }
        public List<FilmData> FilmTmp { get; set; }

        private Core()
        {
            Id = 0;
            Halls = new List<Hall>();
            Films = new List<FilmData>();
            FilmTmp = new List<FilmData>();
            MyPathSettings = @"../../Settings/Settings.txt";
            BoolFormSchedule = new BoolFormSchedule();
            ScheduleAll = new ScheduleAll();
            TimeFreeAll = new TimeFreeAll();
        }

        public static Core GetCore()
        {
            if (_core == null)
            {
                _core = new Core();
            }
            return _core;
        }

        public int Id
        {
            get => _id++;
            private set => _id = value;
        }

        public void CreateSchedule()
        {
            Films = ScheduleAll.Bases;
            foreach (Hall hall in Halls)
            {
                if (hall.GetScheduleFilms != null)
                {
                    hall.Clean_Schedule_Films();
                    hall.Clean_FreeTime_Schedule();
                }
                if (hall.GetSortFilms != null)
                {
                    hall.Clean_Schedule_Sort();
                    hall.Clean_FreeTime_Sort();
                }
                TmpData tmpData = new TmpData(new List<FilmData>(), hall.AllTimeWorkInMinutes);
                CreateGraph(hall, tmpData);
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
            FilmTmp.AddRange(tmpData.Films);
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
            ScheduleAll.Variants.Add(tmpData.Films);
            hall.ScheduleAll.Variants.Add(tmpData.Films);
            tmpData.Films.Clear();
            hall.AllFreeTime.Add(tmpData.Times);

        }        
    }
}
