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
        public List <ScheduleData> data { get; set; }
        public List<ScheduleData> tmp{ get; set; }
        public List<string> NameSessions { get; set; }
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

        public void CreateScheduleData()
        {
            if (Halls[0].AllTimeWorkInMinutes() < 1)
            {

            }
        }
    }
}
