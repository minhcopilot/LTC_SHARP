using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GiuaKy_stt39_PhanLeVanMinh_333
{
    internal class Newspaper: Document
    {
        public DateTime ReleaseDate { get; set; }
        public Newspaper() { }
        public Newspaper(int id, string name, string publisher, int cateId, string author, int pageNumber, DateTime releaseDate) : base(id, name, publisher, cateId)
        {
            ReleaseDate = releaseDate;
        }
    }
}
