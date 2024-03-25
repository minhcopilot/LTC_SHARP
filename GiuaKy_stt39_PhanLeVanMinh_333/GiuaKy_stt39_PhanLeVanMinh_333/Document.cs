using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy_stt39_PhanLeVanMinh_333
{
    internal class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int CateId { get; set; }
        public Document() { }
        public Document(int id, string name, string publisher, int cateId)
        {
            Id = id;
            Name = name;
            Publisher = publisher;
            CateId = cateId;
        }
    }
}
