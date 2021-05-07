using System;
using System.Windows.Forms;

namespace HWCinema.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

       

        private void CreateSchedule_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule(this);
            this.Hide();
            schedule.Show();
        }

        private void Saving_Click(object sender, EventArgs e)
        {

        }

        private void Loading_Click(object sender, EventArgs e)
        {

        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
