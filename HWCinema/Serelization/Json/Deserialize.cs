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
        public StructSettings DeserializerSetting(string data)
        {
            StructSettings settings;
            try
            {
                settings = JsonConvert.DeserializeObject<StructSettings>(data);
            }
            catch
            {
                //settings = null;
            }
            return settings;
        }
    }
}
