using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCinema.CoreFolders
{
    public class ScheduleData
    {
        public string ScheduleLine { get; private set;}

        public ScheduleData(string time, string name)
        {
            ScheduleLine = time + " " + name;
        }
    }
}
