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

        public List<FilmData> Films { get; set; }
        public List<FilmData> FilmsTmp { get; set; }
        public List<FilmData> FilmsVariants { get; set; }
        public List<FilmData> FilmPriority { get; set; }
        public List<Node> Nodes { get; set; }
        public Node Node { get; set; }
        public Node NodeTmp { get; set; }
        public int[] FreeTime { get; set; }

        public List<string> NameSessions { get; set; }
        public string TmpTest = "";

        private Core()
        {
            Halls = new List<Hall>();
            Films = new List<FilmData>();
            FilmsTmp = new List<FilmData>();
            FilmPriority = new List<FilmData>();
            FilmsVariants = new List<FilmData>();

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
                Node = new Node(0);
                CreateGraph(Halls[i]);
            }
        }

        public void CreateGraph(Hall hall)
        {
            foreach (FilmData film in Films)
            {
                if(film.Time <= hall.FreeTime)
                {
                    //FilmsVariants = new List<FilmData>();
                    //foreach (FilmData filmCurrent in Films)
                    //{
                    //    FilmsVariants.Add(filmCurrent);
                    //}
                    hall.FreeTime = film.Time;
                    NodeTmp = new Node(hall, film, _core);
                    Node.Nodes.Add(NodeTmp);
                    Node.NextNode(hall);
                }
            }
        }

        
    }
}
