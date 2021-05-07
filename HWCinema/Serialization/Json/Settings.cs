using HWCinema.CoreFolders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWCinema.Serialization.Structs;

namespace HWCinema.Serialization.Json
{
    public class Settings
    {
        public StructSettings Struct;
        public Settings()
        {
            Struct = new StructSettings();
        }
    }
}
