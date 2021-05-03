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
            _core.GetFreeTime();
            _core.CreateSchedule();            
            for (int i = 0; i < _core.ScheduleHalls[_core.Halls[0]][0].GetFilms.Count; i++)
            {
                TextSchedule.Lines[i] = _core.ScheduleHalls[_core.Halls[0]][0].GetFilms[i].Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
