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
            FilmData film = new FilmData("wqe", 40);
            Hall hall = new Hall("qwe");
            hall.SetFilm = film;
            List<FilmData> test = hall.GetFilms;
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
