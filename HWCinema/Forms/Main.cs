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

        private void Create_Click(object sender, EventArgs e)
        {
            HallsManagement create = new HallsManagement();
            create.Show();
        }

        private void MakeSchedule_Click(object sender, EventArgs e)
        {
            ScheduleManager scheduleManager = new ScheduleManager();
            scheduleManager.Show();
        }

        private void View_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.Show();
        }
    }
}
