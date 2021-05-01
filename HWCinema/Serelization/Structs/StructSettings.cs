using HWСinema.CoreFolders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCinema.Serelization.Structs
{
    public struct StructSettings
    {
        public List<Hall> Halls { get; set; }

        public StructSettings(Core core)
        {
            Halls = core.Halls;
        }
    }
}
