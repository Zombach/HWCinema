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
                CreateGraph(Halls[i]);
                ScheduleHalls.Add(Halls[i], Schedule);
            }
        }

        public void CreateGraph(Hall hall)
        {
            foreach (FilmData film in Films)
            {
                if(film.Time <= hall.FreeTime)
                {
                    List<FilmData> tmp = new List<FilmData>();
                    if (hall.GetFilms != null)
                    {
                        foreach (FilmData filmsSelected in hall.GetFilms)
                        {
                            tmp.Add(filmsSelected);
                        }
                    }
                    tmp.Add(film);
                    Hall = new Hall(hall, film.Time, tmp);
                    CreateGraph(Hall);
                }
            }

            bool test = true;
            foreach (FilmData film in Films)
            {
                if (film.Time <= hall.FreeTime)
                {
                    test = false;
                }
            }
            if (test)
            {
                Schedule.Add(Hall);
            }
        }
        
    }
}
