using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCinema.Serelization.Json
{
    public class Serialize
    {
        private StructSettings _setting = new StructSettings();
        public string Serializer()
        {
            return JsonConvert.SerializeObject(_setting, Formatting.Indented,
                new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });
        }
    }
}
