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
        private int _countFilms;
        public Schedule()
        {
            InitializeComponent();
            _countFilms = 0;
        }

        private void CountFilms_ValueChanged(object sender, EventArgs e)
        {
            if (CountFilms.Value > _countFilms)
            {
                object[] count = new object[(int)CountFilms.Value - _countFilms];
                for (int i = 0; i < count.Length; i++)
                {
                    count[i] = new object();
                }
                NameMovie.Items.AddRange(count);
                _countFilms = (int)CountFilms.Value;
            }
            else if(CountFilms.Value < _countFilms)
            {
                int tmp = _countFilms - (int)CountFilms.Value;
                for (int i = 0; i < tmp; i++)
                {
                    NameMovie.Items.RemoveAt(NameMovie.Items.Count - 1);
                }
                _countFilms = (int)CountFilms.Value;
            }
        }
    }
}
