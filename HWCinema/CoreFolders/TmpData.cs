using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCinema.CoreFolders
{
    public class TmpData
    {
        public List<FilmData> FilmDatas { get; set; }
        public int Times { get; set; }

        public TmpData(List<FilmData> filmDatas, int times)
        {
            FilmDatas = new List<FilmData>();
            FilmDatas.AddRange(filmDatas);
            Times = times;
        }
    }
}
