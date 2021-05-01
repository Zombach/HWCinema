using HWCinema.Serelization.Structs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCinema.Serelization.Json
{
    public class Deserialize
    {
        public Settings DeserializerSetting(string data)
        {
            Settings settings = new Settings();
            try
            {
                settings.Struct = JsonConvert.DeserializeObject<StructSettings>(data);
            }
            catch
            {
                settings = null;
            }
            return settings;
        }
    }
}
