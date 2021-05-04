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
        private Form _filmsManager;
        private Form _hallsManagement;
        private string _empty = "";
        private List<List<FilmData>> _tmpScheduleFilms;
        private List<int> _freeTime;
        public bool IsOpenHallsManager { get; set; } = false;
        public bool IsOpenFilmsManager { get; set; } = false;
        public Schedule(Form menu)
        {
            InitializeComponent();
            ClearLists();
            OpenFormControls();
            _menu = menu;
        }

        private void OpenFormControls()
        {
            FormFilmsManager();
            FormHallsManagement();
        }

        private void FormFilmsManager()
        {
            ScheduleManager filmsManager = new ScheduleManager(this);
            _filmsManager = filmsManager;
            filmsManager.Show();
            IsOpenFilmsManager = true;

        }

        private void FormHallsManagement()
        {
            HallsManagement hallsManagement = new HallsManagement(this);
            _hallsManagement = hallsManagement;
            hallsManagement.Show();
            IsOpenHallsManager = true;
        }

        private void ClearLists()
        {
            _core.Halls.Clear();
            _core.Films.Clear();
        }

        private void CleanAllListBoxs()
        {
            ListSchedule.Items.Clear();
            ListSortEfficiency.Items.Clear();

        }

        private void CleanTmpList()
        {
            _tmpScheduleFilms = new List<List<FilmData>>();
            _freeTime = new List<int>();
        }

        private void WriteAllSchedule()
        {
            CleanAllListBoxs();
            CleanTmpList();
            Write_NameHall(ListSchedule);
            CleanTmpList();
            Write_NameHall(ListSortEfficiency);
        }

        private void Write_NameHall(ListBox listBox)
        {
            for (int i = 0; i < _core.Halls.Count; i++)
            {
                Hall hall = _core.Halls[i];
                string nameHall = $"Зал №{i + 1} - {hall.Name}, время работы зала: {hall.GetTimeWorking()}";
                listBox.Items.Add(_empty);
                listBox.Items.Add(nameHall);
                Write_VariantSchedule(hall, listBox);
            }
        }
        private void Write_VariantSchedule(Hall hall, ListBox listBox)
        {
            int type = GetTypeSchedule(listBox);
            SetTmpList(type, hall);
            for (int i = 0; i < _tmpScheduleFilms.Count; i++)
            {
                
                string variantSchedule = $"Вариант расписания {i + 1}, осталось свободного время {_freeTime[i]}";
                listBox.Items.Add(_empty);
                listBox.Items.Add(variantSchedule);                
                List<FilmData> films = _tmpScheduleFilms[i];
                int timeOpen = hall.GetTimeOpenInMinutes();
                Write_FilmInfo(films, timeOpen, listBox);                
            }
        }

        private void Write_FilmInfo(List<FilmData> films, int timeOpen, ListBox listBox)
        {            
            string timeStart;
            string timeEnd;
            for (int i = 0; i < films.Count; i++)
            {
                string char1 = GetStringCharEmptyOrZero(timeOpen);
                string char2 = GetStringCharEmptyOrZero(timeOpen + films[i].Time);

                timeStart = timeOpen / 60 + ":" + char1 + timeOpen % 60;
                timeEnd = (timeOpen + films[i].Time) / 60 + ":" + char2 + (timeOpen + films[i].Time) % 60;
                string char3 = GetStringCharEmptyOrZero(films[i].Time);
                string filmInfo = $"{timeStart} - {timeEnd} Фильм: {films[i].Name}, фильма идёт: {films[i].Time / 60}:{char3}{films[i].Time % 60}";

                listBox.Items.Add(filmInfo);
                timeOpen += films[i].Time;
            }
        }

        private string GetStringCharEmptyOrZero(int minutes)
        {
            string getChar = "";
            if(minutes % 60 < 10)
            {
                getChar = "0";
            }
            return getChar;
        }

        private void SetTmpList(int type, Hall hall)
        {
            _tmpScheduleFilms = new List<List<FilmData>>();
            _freeTime = new List<int>();
            switch (type)
            {
                case 0:
                    _tmpScheduleFilms.AddRange(hall.GetScheduleFilms);
                    _freeTime.AddRange(hall.AllFreeTime);
                    break;
                case 1:
                    _tmpScheduleFilms.AddRange(hall.GetSortFilms);
                    _freeTime.AddRange(hall.AllFreeTime_Sort);
                    break;
            }
        }

        private int GetTypeSchedule(ListBox listBox)
        {
            switch (listBox.Name)
            {
                case "ListSchedule":
                    return 0;
                case "ListSortEfficiency":
                    return 1;
                default:
                    return -1;
            }
        }

        private void CreateShedule_Click(object sender, EventArgs e)
        {
            _core.CreateSchedule();
        }

        private void ScheduleView_Click(object sender, EventArgs e)
        {
            WriteAllSchedule();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortingSchedules sorting = new SortingSchedules();
            sorting.PreparingSort();
        }

        private void Schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            _filmsManager.Close();
            _hallsManagement.Close();
            _menu.Show();
        }

        private void Schedule_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                _filmsManager.WindowState = FormWindowState.Minimized;
                _hallsManagement.WindowState = FormWindowState.Minimized;
            }
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                _filmsManager.WindowState = FormWindowState.Normal;
                _hallsManagement.WindowState = FormWindowState.Normal;
            }
        }

        private void HallsManager_Click(object sender, EventArgs e)
        {
            if(!IsOpenHallsManager)
            {
                if (_hallsManagement == null)
                {
                    FormHallsManagement();
                }
                else
                {
                    _hallsManagement.Show();
                }
            }
            else
            {
                if (_hallsManagement != null)
                {
                    _hallsManagement.Hide();
                }
            }
            IsOpenHallsManager = !IsOpenHallsManager;
        }

        private void FilmsManager_Click(object sender, EventArgs e)
        {
            if (!IsOpenFilmsManager)
            {
                if (_filmsManager == null)
                {
                    FormFilmsManager();
                }
                else
                {
                    _filmsManager.Show();
                }
            }
            else
            {
                if (_filmsManager != null)
                {
                    _filmsManager.Hide();
                }
            }
            IsOpenFilmsManager = !IsOpenFilmsManager;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
