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
        private Form _menu;
        public Schedule(Form menu)
        {
            InitializeComponent();
            ScheduleManager scheduleManager = new ScheduleManager();
            scheduleManager.Show();
            HallsManagement create = new HallsManagement();
            create.Show();
            //MethodTest();
            _core.CreateSchedule();
            for (int i = 0; i < _core.Halls.Count; i++)
            {
                Hall halls = _core.Halls[i];
                string eee = "";
                string tmp = $"Зал №{i + 1} - {halls.Name}, время работы зала: {halls.GetTimeWorking()}";
                listBox1.Items.Add(eee);
                listBox1.Items.Add(tmp);
                for (int j = 0; j < halls.GetScheduleFilms.Count; j++)
                {
                    string tmp3 = $"Вариант расписания {j+1}";
                    string qwe = "";
                    listBox1.Items.Add(qwe);
                    listBox1.Items.Add(tmp3);
                    int time = halls.GetTimeOpenInMinutes();
                    string timeStart;
                    string timeEnd;
                    List<FilmData> films = halls.GetScheduleFilms[j];
                    for (int k = 0; k < films.Count; k++)
                    {
                        string fix = "";
                        if (time % 60 < 10)
                        {
                            fix = "0";
                        }
                        string fix2 = "";
                        if ((time + films[k].Time) % 60 < 10)
                        {
                            fix2 = "0";
                        }
                        timeStart = time/60 + ":" + fix + time % 60;
                        timeEnd = (time + films[k].Time)/ 60 + ":" + fix2 +(time + films[k].Time) % 60;
                        string fix3 = "";
                        if (films[k].Time % 60 < 10)
                        {
                            fix3 = "0";
                        }
                        string tmp2 = $"{timeStart} - {timeEnd} Фильм: {films[k].Name}, продолжительность фильма: {films[k].Time/60}:{fix3}{films[k].Time % 60}";
                        listBox1.Items.Add(tmp2);
                        time += films[k].Time;
                    }
                     
                }
                  
            }
            _menu = menu;
        }

        private void MethodTest()
        {
            FilmData film = new FilmData("Film 1", 330);
            FilmData film2 = new FilmData("Film 2", 430);
            _core.Films.Add(film);
            _core.Films.Add(film2);
            Hall hall = new Hall("Hall 1");
            _core.Halls.Add(hall);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Schedule_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
