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
        private int _countFilms;
        private int _index; 
        public Schedule()
        {
            InitializeComponent();
            _countFilms = 0;
        }

        private void CountFilms_ValueChanged(object sender, EventArgs e)
        {
            if (CountFilms.Value > _countFilms)
            {
                FilmData[] filmData = new FilmData[(int)CountFilms.Value - _countFilms];
                for (int i = 0; i < filmData.Length; i++)
                {
                    filmData[i] = new FilmData
                    {
                        Name = "",
                        Time = 0
                    };
                }
                NameMovie.Items.AddRange(filmData);
            }
            else if(CountFilms.Value < _countFilms)
            {
                int tmp = _countFilms - (int)CountFilms.Value;
                for (int i = 0; i < tmp; i++)
                {
                    NameMovie.Items.RemoveAt(NameMovie.Items.Count - 1);
                }                
            }
            _countFilms = (int)CountFilms.Value;
        }

        private void NameMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmData tmpTime = (FilmData)NameMovie.Items[NameMovie.SelectedIndex];
            TimeFilm.Value = tmpTime.Time;
            _index = NameMovie.SelectedIndex;
        }

        private void TimeFilm_ValueChanged(object sender, EventArgs e)
        {
            FilmData tmpTime = (FilmData)NameMovie.Items[NameMovie.SelectedIndex];
            tmpTime.Time = (int)TimeFilm.Value;
        }

        private void NameMovie_TextChanged(object sender, EventArgs e)
        {
            FilmData tmpName = (FilmData)NameMovie.Items[_index];
            tmpName.Name = NameMovie.Text;
        }
    }
}
