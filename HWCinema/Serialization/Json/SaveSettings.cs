using HWCinema.CoreFolders;
using System.IO;

namespace HWCinema.Serialization.Json
{
    public class SaveSettings
    {
        public void WriteSettings()
        {
            Core _core = Core.GetCore();
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
