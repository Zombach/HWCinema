using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWСinema.CoreFolders
{
    public class Core
    {
        private static Core _core;
        public List <Hall> Halls { get; set; }
        public List<string> NameSessions { get; set; }
        private Core()
        {
            Halls = new List<Hall>();            
            NameSessions = new List<string>();
        }

        public static Core GetCore()
        {
            if (_core == null)
            {
                _core = new Core();
            }
            return _core;
        }
    }
}
