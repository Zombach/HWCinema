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
        private int _countFilms;
        private int indexName = 1;
        private int _index;
        private FilmData _tmpData;
        public Schedule()
        {
            InitializeComponent();
            FilmsSource.DataSource = _core.Films;
            _countFilms = 0;
        }

        private void CountFilms_ValueChanged(object sender, EventArgs e)
        {
            if (CountFilms.Value > _countFilms)
            {
                FilmData[] filmData = new FilmData[(int)CountFilms.Value - _countFilms];
                for (int i = 0; i < filmData.Length; i++)
                {
                    filmData[i] = new FilmData("Фильм " + indexName++);                    
                }
                _core.Films.AddRange(filmData);
            }
            else if(CountFilms.Value < _countFilms)
            {
                int tmp = _countFilms - (int)CountFilms.Value;
                for (int i = 0; i < tmp; i++)
                {
                    _core.Films.RemoveAt(_core.Films.Count - 1);
                    indexName--;
                }                
            }
            _countFilms = (int)CountFilms.Value;
            FilmsSource.ResetBindings(true);
        }

        private void NameMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_core.Films.Count != 0)
            {
                if (NameMovie.SelectedIndex != -1)
                {
                    _tmpData = (FilmData)NameMovie.Items[NameMovie.SelectedIndex];
                    TimeFilm.Value = _tmpData.Time;
                    _index = NameMovie.SelectedIndex;
                }
            }
        }

        private void TimeFilm_ValueChanged(object sender, EventArgs e)
        {
            _tmpData = _core.Films[NameMovie.SelectedIndex];
            _tmpData.Time = (int)TimeFilm.Value;
        }

        private void NameMovie_TextChanged(object sender, EventArgs e)
        {
            _core.Films[_index].Name = NameMovie.Text;
            FilmsSource.ResetBindings(true);
        }
    }
}
