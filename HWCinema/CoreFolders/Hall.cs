using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWСinema.CoreFolders
{
    public class Hall
    {
        private string _time;
        private string _zeroChar_H = "";
        private string _zeroChar_M = "";


        public string Name { get; set; }
        public int HourOpening { get; set; }
        //{
        //    get
        //    {
        //        return HourOpening;
        //    }
        //    set
        //    {
        //        if (value < 0 || value > 12)
        //        {
        //            value = 0;
        //        }
        //    }
        //}
        public int HourClosing { get; set; }
        //{
        //    get
        //    {
        //        return HourClosing;
        //    }
        //    set
        //    {
        //        if (value < 0 || value > 12)
        //        {
        //            value = 0;
        //        }
        //    }
        //}

        public int MinutesOpen { get; set; }
        //{
        //    get
        //    {
        //        return MinutesOpen;
        //    }
        //    set
        //    {
        //        if (value < 0 || value > 60)
        //        {
        //            value = 0;
        //        }
        //    }
        //}
        public int MinutesClosing { get; set; }
        //{
        //    get
        //    {
        //        return MinutesClosing;
        //    }
        //    set
        //    {
        //        if (value < 0 || value > 60)
        //        {
        //            value = 0;
        //        }
        //    }
        //}

        public Hall(string name)
        {
            Name = name;
            HourOpening = 0;
            HourClosing = 0;
            MinutesOpen = 0;
            MinutesClosing = 0;
        }

        public void SetTimeOpening(int hour, int minutes)
        {
            HourOpening = hour;
            MinutesOpen = minutes;
        }
        public void SetTimeClosing(int hour, int minutes)
        {
            HourClosing = hour;
            MinutesClosing = minutes;
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
            if (isOpen)
            {
                if (HourOpening < 10)
                {
                    _zeroChar_H = "0";
                }
            }
            else
            {
                if (HourClosing < 10)
                {
                    _zeroChar_H = "0";
                }
            }
        }
        private void SetZeroChar_M(bool isOpen)
        {
            if (isOpen)
            {
                if (MinutesOpen < 10)
                {
                    _zeroChar_M = "0";
                }
            }
            else
            {
                if (MinutesClosing < 10)
                {
                    _zeroChar_M = "0";
                }
            }
        }
        
    }
}
