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
        private int _index;
        private List<int> _timeFilms = new List<int>();   
        public Schedule()
        {
            InitializeComponent();
            _countFilms = 0;
        }

        private void CountFilms_ValueChanged(object sender, EventArgs e)
        {
            if (CountFilms.Value > _countFilms)
            {
                string[] count = new string[(int)CountFilms.Value - _countFilms];
                for (int i = 0; i < count.Length; i++)
                {
                    count[i] = "";
                    _timeFilms.Add(0);
                }
                NameMovie.Items.AddRange(count);
            }
            else if(CountFilms.Value < _countFilms)
            {
                int tmp = _countFilms - (int)CountFilms.Value;
                for (int i = 0; i < tmp; i++)
                {
                    NameMovie.Items.RemoveAt(NameMovie.Items.Count - 1);
                    _timeFilms.RemoveAt(NameMovie.Items.Count - 1);
                }                
            }
            _countFilms = (int)CountFilms.Value;
        }

        private void NameMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeFilm.Value = _timeFilms[NameMovie.SelectedIndex];
            _index = NameMovie.SelectedIndex;
        }

        private void TimeFilm_ValueChanged(object sender, EventArgs e)
        {
            _timeFilms[NameMovie.SelectedIndex] = (int)TimeFilm.Value;
        }

        private void NameMovie_TextChanged(object sender, EventArgs e)
        {            
            NameMovie.Items[_index] = NameMovie.Text;
        }
    }
}
