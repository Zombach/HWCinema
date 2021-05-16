using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCinema.CoreFolders
{
    public class Hall
    {
        private string _time;
        private string _zeroCharH = "";
        private string _zeroCharM = "";
        private string _name;
        private int _hourOpen;
        private int _minutesOpen;
        private int _hourClose;
        private int _minutesClose;
        private int _timeWorkInMinutes;
        private List<int> _freeTimeSchedule;
        private List<int> _fteeTimeSort;
        private List<List<FilmData>> _scheduleFilms;
        private List<List<FilmData>> _sortSchedule;
        private List<FilmData> _bestSortEfficiency;
        private List<FilmData> _films;

        public void Clean_FreeTime_Shcedule()
        {
            _freeTimeSchedule = new List<int>();
        }
        public void Clean_FreeTime_Sort()
        {
            _fteeTimeSort = new List<int>();
        }
        public void Clean_Schedule_Sort()
        {
            _sortSchedule = new List<List<FilmData>>();
        }
        public List<List<FilmData>> GetSortFilms
        {
            get => _sortSchedule ?? (_sortSchedule = new List<List<FilmData>>());
            private set => _scheduleFilms = value;
        }

        public List<FilmData> GetBestSortFilms
        {
            get => _bestSortEfficiency ?? (_bestSortEfficiency = new List<FilmData>());
            private set => _bestSortEfficiency = value;
        }

        public List<List<FilmData>> SetSort
        {
            private get
            {
                return _sortSchedule;
            }
            set
            {
                if (_sortSchedule == null)
                {
                    _sortSchedule = new List<List<FilmData>>();
                }    
                _sortSchedule.AddRange(value);
            }
        }

        public bool RemoveFilms
        {
            private get
            {
                return true;
            }
            set
            {
                _films.Clear();
                _freeTimeSchedule.Clear();
                _freeTimeSchedule.Add(_timeWorkInMinutes);
            }
        }
        public bool RemoveLastFilm
        {
            private get
            {
                return true;
            }
            set
            {
                if (_films.Count != 0)
                {
                    _freeTimeSchedule.RemoveAt(_freeTimeSchedule.Count - 1);
                    _films.RemoveAt(_films.Count -1);
                }
            }
        }
        public List<int> AllFreeTime_Sort
        {
            get => _fteeTimeSort;
            set
            {
                if (_fteeTimeSort == null)
                {
                    _fteeTimeSort = new List<int>();
                }
                _fteeTimeSort.Clear();
                _fteeTimeSort.AddRange(value);
            }
        }
        public List<int> AllFreeTime
        {
            get => _freeTimeSchedule;
            set
            {
                _freeTimeSchedule.Clear();
                _freeTimeSchedule.AddRange(value);
            }
        }

        public int FreeTime
        {
            get => _freeTimeSchedule[_freeTimeSchedule.Count -1];
            set => _freeTimeSchedule[_freeTimeSchedule.Count - 1] -= value;
        }

        public List<List<FilmData>> GetScheduleFilms
        {
            get
            {
                if (_scheduleFilms == null)
                {
                    _scheduleFilms = new List<List<FilmData>>();
                }
                return _scheduleFilms;
            }
            private set
            {
            }
        }
        public List<FilmData> GetFilms
        {
            get
            {
                if (_films == null)
                {
                    _films = new List<FilmData>();
                }

                if (_scheduleFilms.Count != 0)
                {
                    _films = _scheduleFilms[_scheduleFilms.Count - 1];
                }
                return _films;
            }
            private set
            {

            }
        }

        public void Clean_Schedule_Films()
        {
            _scheduleFilms = new List<List<FilmData>>();
        }
        public List<List<FilmData>> SetScheduleFilms
        {
            get => new List<List<FilmData>>();
            set => _scheduleFilms = value;
        }
        public List<FilmData> SetFilms
        {
            get => _scheduleFilms[_scheduleFilms.Count - 1];
            set
            {
                _films = new List<FilmData>();
                _films.AddRange(value);
                _scheduleFilms.Add(_films);
            }
        }



        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int HourOpening
        {
            get => _hourOpen;
            set
            {
                if (value < 10 || value > 23)
                {
                    _hourOpen = 10;
                }
                else
                {
                    _hourOpen = value;
                }
            }
        }
        public int HourClosing
        {
            get => _hourClose;
            set
            {
                if (value < 10 || value > 23)
                {
                    _hourClose = 0;
                }
                else
                {
                    _hourClose = value;
                }
            }
        }
        public int MinutesOpen
        {
            get => _minutesOpen;
            set
            {
                if (value < 0 || value > 59)
                {
                    _minutesOpen = 0;
                }
                else
                {
                    _minutesOpen = value;
                }
            }
        }
        public int MinutesClosing
        {
            get => _minutesClose;
            set
            {
                if (_hourClose == 0)
                {
                    _minutesClose = 0;
                }
                else
                {
                    if (value < 0 || value > 59)
                    {
                        _minutesClose = 59;
                    }
                    else
                    {
                        _minutesClose = value;
                    }
                }                
            }
        }

        public int AllTimeWorkInMinutes
        {
            get
            {
                int hourClose = _hourClose;
                if (_hourClose == 0)
                {
                    hourClose = 24;
                }
                int tmpHour = hourClose - _hourOpen;
                int tmpMinutes = _minutesClose - _minutesOpen;
                _timeWorkInMinutes = tmpHour * 60 + tmpMinutes;
                return _timeWorkInMinutes;
            }
            private set
            {                
            }
        }


        public Hall(string name)
        {
            _name = name;
            _hourOpen = 10;
            _hourClose = 00;
            _minutesOpen = 00;
            _minutesClose = 00;
            _timeWorkInMinutes = AllTimeWorkInMinutes;
            _freeTimeSchedule = new List<int>();
            _films = new List<FilmData>();
            _scheduleFilms = new List<List<FilmData>>();
        }

        public void SetTimeOpening(string hour, string minutes)
        {
            HourOpening = Convert.ToInt32(hour);
            MinutesOpen = Convert.ToInt32(minutes);
        }
        public void SetTimeClosing(string hour, string minutes)
        {
            HourClosing = Convert.ToInt32(hour);
            MinutesClosing = Convert.ToInt32(minutes);
        }

        public string GetTimeWorking()
        {
            string timeWorking = GetTimeOpenOrClose(true) + " - " + GetTimeOpenOrClose(false);
            return timeWorking;
        }
        public string GetTimeOpening()
        {
            return GetTimeOpenOrClose(true);
        }

        public string GetTimeClosing()
        {
            return GetTimeOpenOrClose(false);
        }

        private string GetTimeOpenOrClose(bool isOpen)
        {
            SetZeroChar_H(isOpen);
            SetZeroChar_M(isOpen);
            SetTimes(isOpen);
            return _time;
        }

        public int GetTimeOpenInMinutes()
        {
            int tmp = _hourOpen * 60 + _minutesOpen;
            return tmp;
        }
       
        private void SetTimes(bool isOpen)
        {
            if(isOpen)
            {
                _time = _zeroCharH + HourOpening + ":" + _zeroCharM + MinutesOpen;
            }
            else
            {
                _time = _zeroCharH + HourClosing + ":" + _zeroCharM + MinutesClosing;
            }
        }
        private void SetZeroChar_H(bool isOpen)
        {
            _zeroCharH = "";
            if (isOpen)
            {
                if (_hourOpen < 10)
                {
                    _zeroCharH = "0";
                }
            }
            else
            {
                if (_hourClose < 10)
                {
                    _zeroCharH = "0";
                }
            }
        }
        private void SetZeroChar_M(bool isOpen)
        {
            _zeroCharM = "";
            if (isOpen)
            {
                if (_minutesOpen < 10)
                {
                    _zeroCharM = "0";
                }
            }
            else
            {
                if (_minutesClose< 10)
                {
                    _zeroCharM = "0";
                }
            }
        }

        public override bool Equals(object obj)
        {
            Hall hall = (Hall)obj;
            if (this.Name != hall.Name)
            {
                return false;
            }
            if (this._hourOpen != hall._hourOpen)
            {
                return false;
            }
            if (this._hourClose != hall._hourClose)
            {
                return false;
            }
            if (this._minutesOpen != hall._minutesOpen)
            {
                return false;
            }
            if (this._minutesClose != hall._minutesClose)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = -910441382;
            hashCode = hashCode * -1521134295 + _hourOpen.GetHashCode();
            hashCode = hashCode * -1521134295 + _minutesOpen.GetHashCode();
            hashCode = hashCode * -1521134295 + _hourClose.GetHashCode();
            hashCode = hashCode * -1521134295 + _minutesClose.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
