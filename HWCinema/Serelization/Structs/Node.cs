using HWCinema.CoreFolders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCinema.Serelization.Structs
{
    public struct Node
    {
        public Hall Hall { get; set; }
        public int FreeTime { get; set; }
        public List <FilmData> FilmsVariants { get; set; }
        public bool IsPriority { get; set; }
        public bool RepeatOtherHalls { get; set; }
        public int RepeatCount { get; set; }
        public List <Node> Nodes { get; set; }

        public Node(Hall hall, FilmData film, Core core)
        {
            Hall = hall;
            FreeTime = hall.FreeTime;
            if (core.FilmsVariants == null)
            {
                FilmsVariants = new List<FilmData>();
            }
            else
            {
                FilmsVariants = core.FilmsVariants;
            }
            IsPriority = film.IsPriority;
            RepeatOtherHalls = film.RepeatOtherHalls;
            RepeatCount = film.RepeatCount;
            Nodes = new List<Node>();
        }

        public Node(int count)
        {
            Hall = null;
            FreeTime = count;
            FilmsVariants = new List<FilmData>();
            IsPriority = false;
            RepeatOtherHalls = false;
            RepeatCount = count;
            Nodes = new List<Node>();
        }
        public void NextNode(Hall hall)
        {
            Core core = Core.GetCore();
            core.CreateGraph(hall);
        }
    }
}
