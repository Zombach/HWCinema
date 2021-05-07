using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWCinema.Serialization.Structs;

namespace HWCinema.Serialization.Json
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
