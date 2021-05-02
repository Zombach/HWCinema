using HWCinema.CoreFolders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWCinema.Forms
{
    public partial class Schedule : Form
    {
        private Core _core = Core.GetCore();
        public Schedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilmData film = new FilmData("wqe", 340);
            _core.Films.Add(film);
            FilmData film2 = new FilmData("222", 420);
            _core.Films.Add(film2);
            Hall hall = new Hall("qwe");
            
            _core.Halls.Add(hall);
            hall.SetFilm = film;
            List<FilmData> test = hall.GetFilms;
            _core.GetFreeTime();
            _core.CreateSchedule();
            //Node.Films = new List<FilmData>() { new FilmData("wqe", 99), new FilmData("ddd", 151) };
            //Node qqq = new Node(200);
            //qqq.CreateSchedule(200);
            //qqq.WriteAllEnds();
            //List<List<string>> sss = qqq.Test2();



            //ScheduleData data = new ScheduleData();
            //_core.GetFreeTime();
            ////data.PreparingSchedules();
            //data.CreateSchedules();
            //data.WriteSchedule();
            //data.Message();
        }
    }
}
