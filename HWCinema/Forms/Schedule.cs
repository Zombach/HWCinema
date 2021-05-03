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
            FilmData film = new FilmData("Film 1", 330);
            FilmData film2 = new FilmData("Film 2", 430);
            _core.Films.Add(film);
            _core.Films.Add(film2);
            Hall hall = new Hall("Hall 1");
            _core.Halls.Add(hall);
            _core.CreateSchedule();
            for (int i = 0; i < _core.Halls.Count; i++)
            {
                Hall halls = _core.Halls[i];
                string tmp = $"Зал №{i + 1} - {halls.Name}, время работы зала: {halls.GetTimeWorking()}";
                listBox1.Items.Add(tmp);
                for (int j = 0; j < halls.GetScheduleFilms.Count; j++)
                {
                    List<FilmData> films = halls.GetScheduleFilms[j];
                    for (int k = 0; k < films.Count; k++)
                    {
                        string tmp2 = $"Фильм: {films[k].Name}, продолжительность фильма: {films[k].Time} минут";
                        listBox1.Items.Add(tmp2);
                    }
                     
                }
                  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
