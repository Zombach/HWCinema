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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

       

        private void CreateSchedule_Click(object sender, EventArgs e)
        {
            HallsManagement create = new HallsManagement(this);
            create.Show();
            Schedule schedule = new Schedule(this);
            schedule.Show();
            ScheduleManager scheduleManager = new ScheduleManager(this);
            scheduleManager.Show();
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
