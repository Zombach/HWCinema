using HWCinema.Serelization.Structs;
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
        private string _zeroChar_H = "";
        private string _zeroChar_M = "";
        private string _name;
        private int _hourOpen;
        private int _minutesOpen;
        private int _hourClose;
        private int _minutesClose;
        private int _timeWorkInMinutes;
        private List<int> _freeTime;
        private List<List<FilmData>> _scheduleFilms;
        private List<FilmData> _films;

        public bool RemoveFilms
        {
            private get
            {
                return true;
            }
            set
            {
                _films.Clear();
                _freeTime.Clear();
                _freeTime.Add(_timeWorkInMinutes);
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
                    _freeTime.RemoveAt(_freeTime.Count - 1);
                    _films.RemoveAt(_films.Count -1);
                }
            }
        }
        public List<int> AllFreeTime
        {
            get
            {
                return _freeTime;
            }
            set
            {
                _freeTime.Clear();
                _freeTime.AddRange(value);
            }
        }

        public int FreeTime
        {
            get
            {
                return _freeTime[_freeTime.Count -1];
            }
            set
            {
                _freeTime[_freeTime.Count - 1] -= value;
            }
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
        public List<List<FilmData>> SetScheduleFilms
        {
            get
            {
                return new List<List<FilmData>>();
            }
            set
            {
                _scheduleFilms = value;
            }
        }
        public List<FilmData> SetFilms
        {
            get
            {
                return _scheduleFilms[_scheduleFilms.Count - 1];
            }
            set
            {
                _films = new List<FilmData>();
                _films.AddRange(value);
                _scheduleFilms.Add(_films);
            }
        }



        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int HourOpening
        {
            get
            {
                return _hourOpen;
            }
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
            get
            {
                return _hourClose;
            }
            set
            {
                if (value < 10 || value > 23)
                {
                    _hourClose = 23;
                }
                else
                {
                    _hourClose = value;
                }
            }
        }
        public int MinutesOpen
        {
            get
            {
                return _minutesOpen;
            }
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
            get
            {
                return _minutesClose;
            }
            set
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

        public int AllTimeWorkInMinutes
        {
            get
            {
                int tmpHour = _hourClose - _hourOpen;
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
            _hourClose = 23;
            _minutesOpen = 00;
            _minutesClose = 59;
            _timeWorkInMinutes = AllTimeWorkInMinutes;
            _freeTime = new List<int>();
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

        private void SetTimes(bool isOpen)
        {
            if(isOpen)
            {
                _time = _zeroChar_H + HourOpening + ":" + _zeroChar_M + MinutesOpen;
            }
            else
            {
                _time = _zeroChar_H + HourClosing + ":" + _zeroChar_M + MinutesClosing;
            }
        }
        private void SetZeroChar_H(bool isOpen)
        {
            _zeroChar_H = "";
            if (isOpen)
            {
                if (_hourOpen < 10)
                {
                    _zeroChar_H = "0";
                }
            }
            else
            {
                if (_hourClose < 10)
                {
                    _zeroChar_H = "0";
                }
            }
        }
        private void SetZeroChar_M(bool isOpen)
        {
            _zeroChar_M = "";
            if (isOpen)
            {
                if (_minutesOpen < 10)
                {
                    _zeroChar_M = "0";
                }
            }
            else
            {
                if (_minutesClose< 10)
                {
                    _zeroChar_M = "0";
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
