using HWCinema.CoreFolders;
using System;
using System.Windows.Forms;

namespace HWCinema.Forms
{
    public partial class ScheduleManager : Form
    {
        private Core _core = Core.GetCore();
        private readonly Schedule _schedule;
        private int _countFilms;
        private int _indexName = 1;
        private int _index;
        private FilmData _tmpData;
        private string _tmpName;
        private bool _isChangeName = false;
        public int DefaultTime { get; set; }
        public ScheduleManager(Form schedule)
        {
            InitializeComponent();
            FilmsSource.DataSource = _core.Films;
            _countFilms = 0;
            DefaultTime = 60;
            _schedule = (Schedule)schedule;
        }

        private void CountFilms_ValueChanged(object sender, EventArgs e)
        {
            if (CountFilms.Value > _countFilms)
            {
                FilmData[] filmData = new FilmData[(int)CountFilms.Value - _countFilms];
                for (int i = 0; i < filmData.Length; i++)
                {
                    string name = "Фильм ";
                    filmData[i] = new FilmData(name + _indexName++, DefaultTime);                    
                }
                _core.Films.AddRange(filmData);
            }
            else if(CountFilms.Value < _countFilms)
            {
                int tmp = _countFilms - (int)CountFilms.Value;
                for (int i = 0; i < tmp; i++)
                {
                    _core.Films.RemoveAt(_core.Films.Count - 1);
                    _indexName--;
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
                    _tmpData = _core.Films[NameMovie.SelectedIndex];
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
            _isChangeName = true;
            _tmpName = NameMovie.Text;
        }

        private void ChangeNameMovies()
        {
            _core.Films[_index].Name = _tmpName;
            FilmsSource.ResetBindings(true);            
        }

        private void NameMovie_Click(object sender, EventArgs e)
        {
            if (_isChangeName)
            {
                ChangeNameMovies();
                _isChangeName = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ScheduleManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _schedule.IsOpenFilmsManager = false;
            this.Hide();
        }
    }
}
