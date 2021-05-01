using HWСinema.CoreFolders;
using System.IO;

namespace HWCinema.Serelization.Json
{
    public class SaveSettings
    {
        private Core _core = Core.GetCore();
        public void WriteSettings()
        {
            Serialize _serializer = new Serialize();
            using (FileStream fileStream = new FileStream(_core.MyPathSettings, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine(_serializer.Serializer());
                    streamWriter.Close();
                }
                fileStream.Close();
            }
        }
    }
}
