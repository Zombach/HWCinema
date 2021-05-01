using HWCinema.Serelization.Structs;
using HWCinema.CoreFolders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCinema.Serelization.Json
{
    public class LoadSettings
    {
        private Deserialize _deserializer = new Deserialize();
        public StructSettings ReadSettings()
        {
            Core core = Core.GetCore();
            Settings settings;
            using (FileStream fileStream = new FileStream(core.MyPathSettings, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    settings = _deserializer.DeserializerSetting(streamReader.ReadToEnd());
                    streamReader.Close();
                }
                fileStream.Close();
            }
            return settings.Struct;
        }
    }
}
