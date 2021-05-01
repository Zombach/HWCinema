using HWСinema.CoreFolders;
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
        public void ReadSettings()
        {
            using (FileStream fileStream = new FileStream(Core.GetCore().MyPathSettings, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    //settings = _deserializer.DeserializerSetting(streamReader.ReadToEnd());
                    streamReader.Close();
                }
                fileStream.Close();
            }
        }
    }
}
