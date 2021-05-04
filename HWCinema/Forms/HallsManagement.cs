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
    public partial class HallsManagement : Form
    {
        private Core _core = Core.GetCore();
        private bool isActiveButton;
        private Schedule _schedule;
        public HallsManagement(Form schedule)
        {
            InitializeComponent();
            Enable(false);
            HallsSource.DataSource = _core.Halls;           
            HallsSource.ResetBindings(true);
            _schedule = (Schedule)schedule;
        }

        private void Enable(bool isOn)
        {
            TimeOpenHours.Enabled = isOn;
            TimeOpenMinutes.Enabled = isOn;
            TimeCloseHours.Enabled = isOn;
            TimeCloseMinutes.Enabled = isOn;
            SetTimeWork.Enabled = isOn;
            RemoveHall.Enabled = isOn;
        }

        private void AddHall_Click(object sender, EventArgs e)
        {
            if (isActiveButton)
            {
                bool isOk = CheckName();
                if (isOk)
                {
                    Hall hall = new Hall(NameNewHall.Text);
                    NameNewHall.Text = "";
                    _core.Halls.Add(hall);
                    HallsSource.ResetBindings(false);
                    Halls.SelectedIndex = HallsSource.Count - 1;
                    if (HallsSource.Count - 1 == 0)
                    {
                        Hall hall2 = new Hall(" ");
                        _core.Halls.Add(hall2);
                        HallsSource.ResetBindings(true);
                        Halls.SelectedIndex = 1;
                        _core.Halls.RemoveAt(1);
                        HallsSource.ResetBindings(true);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите название зала");
            }
        }


        private bool CheckName()
        {
            bool isOk = true;            
            bool isLength = CheckNameHall();
            bool isRepeat = CheckNameRepeat();
            if (!isRepeat || !isLength)
            {
                isOk = false;
            }
            return isOk;
        }

        private bool CheckNameRepeat()
        {
            bool isRepeat = true;
            foreach (Hall hall in _core.Halls)
            {
                if (NameNewHall.Text == hall.Name)
                {
                    isRepeat = false;
                    break;
                }
            }
            return isRepeat;
        }

        private bool CheckNameHall()
        {
            bool isLength = true;
            if (NameNewHall.Text.Length > 10)
            {
                MessageBox.Show("Укажите более короткое название");
                isLength = false;
            }

            if (NameNewHall.Text.Length < 3)
            {
                MessageBox.Show("Укажите более длинное название");
                isLength = false;
            }
            return isLength;
        }

        private void NameNewHall_TextChanged(object sender, EventArgs e)
        {
            if (NameNewHall.Text == "")
            {
                isActiveButton = false;
            }
            else
            {
                isActiveButton = true;
            }
        }

        private void RemoveHall_Click(object sender, EventArgs e)
        {
            if (_core.Halls.Count != 0)
            {
                _core.Halls.Remove(_core.Halls[Halls.SelectedIndex]);
                Halls.SelectedIndex = 0;
                HallsSource.ResetBindings(true);
            }
            else
            {
                MessageBox.Show("Нечего удалять");
            }
        }

        private void Halls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Halls.SelectedIndex !=-1)
            {
                string tmpTime = _core.Halls[Halls.SelectedIndex].GetTimeOpening();
                string[] hourAndMinutes = tmpTime.Split(':');
                TimeOpenHours.Text = hourAndMinutes[0];
                TimeOpenMinutes.Text = hourAndMinutes[1];

                tmpTime = _core.Halls[Halls.SelectedIndex].GetTimeClosing();
                hourAndMinutes = tmpTime.Split(':');
                TimeCloseHours.Text = hourAndMinutes[0];
                TimeCloseMinutes.Text = hourAndMinutes[1];
                Enable(true);
            }
            else
            {
                Enable(false);
            }
        }

        private void SetTimeWork_Click(object sender, EventArgs e)
        {
            _core.Halls[Halls.SelectedIndex].SetTimeOpening(TimeOpenHours.Text, TimeOpenMinutes.Text);
            _core.Halls[Halls.SelectedIndex].SetTimeClosing(TimeCloseHours.Text, TimeCloseMinutes.Text);
        }

        private void HallsManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _schedule.IsOpenHallsManager = false;
            this.Hide();
        }
    }
}
