using System.Collections.Generic;

namespace HWCinema.CoreFolders
{
    public class TmpData
    {
        public List<FilmData> Films { get; private set; }
        public int Times { get; private set; }

        public TmpData(List<FilmData> data, int times)
        {
            Films = new List<FilmData>();
            Films.AddRange(data);
            Times = times;
        }
    }
}
