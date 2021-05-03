using HWCinema.Serelization.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWCinema.CoreFolders
{
    public class Core
    {
        private static Core _core;
        public string MyPathSettings { get; set; }
        public List <Hall> Halls { get; set; }
        public List<Hall> Schedule { get; set; }
        public Dictionary<Hall, List<Hall>> ScheduleHalls { get; set; }

        public List<FilmData> Films { get; set; }
        public List<FilmData> FilmsTmp { get; set; }
        public List<FilmData> FilmsSelected { get; set; }
        public List<FilmData> FilmPriority { get; set; }
        public Hall Hall { get; set; }
        public int[] FreeTime { get; set; }

        public List<string> NameSessions { get; set; }
        public string TmpTest = "";

        private Core()
        {
            Halls = new List<Hall>();
            Films = new List<FilmData>();
            FilmsTmp = new List<FilmData>();
            FilmPriority = new List<FilmData>();
            FilmsSelected = new List<FilmData>();
            ScheduleHalls = new Dictionary<Hall, List<Hall>>();
            Schedule = new List<Hall>();

            NameSessions = new List<string>();
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
        public void GetFreeTime()
        {
            FreeTime = new int[Halls.Count];
            for (int i = 0; i < Halls.Count; i++)
            {
                FreeTime[i] = Halls[i].FreeTime;
            }
        }
        public void CreateSchedule()
        {
            for (int i = 0; i < Halls.Count; i++)
            {
                Schedule.Clear();
                TmpData tmpData = new TmpData(new List<FilmData>(), Halls[i].AllTimeWorkInMinutes);
                CreateGraph(Halls[i], tmpData);
                //Halls[i].SetFilm = Schedule;
                //ScheduleHalls.Add(Halls[i], Schedule);
            }
        }


        public void CreateGraph(Hall hall, TmpData tmpData)
        {  
            
            foreach (FilmData film in Films)
            {
                if(film.Time <= tmpData.Times)
                {
                    List<FilmData> tmp = new List<FilmData>();
                    if (tmpData.FilmDatas != null)
                    {
                        foreach (FilmData filmsSelected in tmpData.FilmDatas)
                        {
                            tmp.Add(filmsSelected);
                        }
                    }
                    tmp.Add(film);

                    TmpData DataTmp = new TmpData(tmp, tmpData.Times - film.Time);
                    CreateGraph(hall, DataTmp);
                }
            }

            bool test = true;
            foreach (FilmData film in Films)
            {
                if (film.Time <= tmpData.Times)
                {
                    test = false;
                }
            }
            if (test)
            {
                hall.SetFilms = tmpData.FilmDatas;
                tmpData.FilmDatas.Clear();
                hall.AllFreeTime.Add(tmpData.Times);
                //Schedule.Add(hall);
            }
        }
        
    }
}
