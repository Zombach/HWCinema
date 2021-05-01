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
        public HallsManagement()
        {
            InitializeComponent();
            HallsSource.DataSource = _core.Halls;
            _core.Halls.Add(new Hall("тест"));
            _core.Halls.Add(new Hall("qdw"));
            _core.Halls.Add(new Hall("ad"));            
            HallsSource.ResetBindings(true);
        }

        private void AddHall_Click(object sender, EventArgs e)
        {
            if (isActiveButton)
            {
                CheckNameHall();
                Hall hall = new Hall(NameNewHall.Text);
                NameNewHall.Text = "";
                _core.Halls.Add(hall);
                HallsSource.ResetBindings(true);
                Halls.SelectedIndex = HallsSource.Count - 1;
            }
            else
            {
                MessageBox.Show("Введите название зала");
            }
        }

        private void CheckNameHall()
        {
            if (NameNewHall.Text.Length > 10)
            {
                MessageBox.Show("Укажите более короткое название");
            }
            if (NameNewHall.Text.Length < 3)
            {
                MessageBox.Show("Укажите более длинное название");
            }
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
            if (Halls.SelectedIndex != -1)
            {
                string tmpTime = _core.Halls[Halls.SelectedIndex].GetTimeOpening();
                string[] hourAndMinutes = tmpTime.Split(':');
                TimeOpenHours.Text = hourAndMinutes[0];
                TimeOpenMinutes.Text = hourAndMinutes[1];

                tmpTime = _core.Halls[Halls.SelectedIndex].GetTimeClosing();
                hourAndMinutes = tmpTime.Split(':');
                TimeCloseHours.Text = hourAndMinutes[0];
                TimeCloseMinutes.Text = hourAndMinutes[1];
            }
        }

        private void SetTimeWork_Click(object sender, EventArgs e)
        {
            _core.Halls[Halls.SelectedIndex].SetTimeOpening(TimeOpenHours.Text, TimeOpenMinutes.Text);
            _core.Halls[Halls.SelectedIndex].SetTimeClosing(TimeCloseHours.Text, TimeCloseMinutes.Text);
        }
    }
}
