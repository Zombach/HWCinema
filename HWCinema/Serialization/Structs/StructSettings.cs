using System.Collections.Generic;
using HWCinema.CoreFolders;

namespace HWCinema.Serialization.Structs
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
