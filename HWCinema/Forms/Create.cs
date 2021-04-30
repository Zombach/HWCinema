using HWСinema.CoreFolders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWСinema.Forms
{
    public partial class Create : Form
    {
        private Core _core = Core.GetCore();
        private bool isActiveButton;
        public Create()
        {
            InitializeComponent();
            CoreSource.DataSource = _core.Halls;
            _core.Halls.Add(new Hall("тест"));
            _core.Halls.Add(new Hall("qdw"));
            _core.Halls.Add(new Hall("ad"));            
            CoreSource.ResetBindings(true);
        }

        private void AddHall_Click(object sender, EventArgs e)
        {
            if (isActiveButton)
            {
                CheckNameHall();
                Hall hall = new Hall(NameNewHall.Text);
                NameNewHall.Text = "";
                _core.Halls.Add(hall);
                CoreSource.ResetBindings(true);
                Halls.SelectedIndex = CoreSource.Count - 1;
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
                MessageBox.Show("Укажите более коротнкое название");
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
                CoreSource.ResetBindings(true);
            }
            else
            {
                MessageBox.Show("Нечего удалять");
            }
        }

        private void Halls_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeOpen.Text = _core.Halls[Halls.SelectedIndex].GetTimeOpening();
            TimeClose.Text = _core.Halls[Halls.SelectedIndex].GetTimeClosing();
        }
    }
}
