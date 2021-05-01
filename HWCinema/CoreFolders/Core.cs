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

        public List<FilmData> Films { get; set; }
        public List<FilmData> currentFilms { get; set; } = new List<FilmData>();
        public int FreeTime { get; set; }

        public List<ScheduleData> Data { get; set; } = new List<ScheduleData>();

        public List<string> NameSessions { get; set; }
        private string _tmptest;
        private Core()
        {
            Halls = new List<Hall>();
            Films = new List<FilmData>();
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
        public void CreateSchedules()
        {
            foreach (Hall hall in Halls)
            {
                FreeTime += hall.AllTimeWorkInMinutes();
            }
        }

        
        public void CreateScheduleData()
        {
            //    bool end = true;
            //    foreach (FilmData film in Films)
            //    {
            //        //int timeTmp = Halls[0].AllTimeWorkInMinutes();
            //        if (_tmpInt < film.Time)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            int tmptmp = _tmpInt;
            //            foreach (FilmData filmdata in Films)
            //            {
            //                tmptmp -= filmdata.Time;
            //                if (filmdata.Time < _tmpInt)
            //                {
            //                    currentFilms.Add(filmdata);
            //                }
            //            }
            //        }                
            //    }

            //    if (end)
            //    {
            //        foreach (FilmData filmdata in currentFilms)
            //        {
            //            _tmptest +=(filmdata.Name + " ");
            //        }
            //        MessageBox.Show(_tmptest);
            //        _tmptest = "";
            //    }
        }
    }
}
