using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy_stt39_PhanLeVanMinh_333
{
    internal class Magazine: Document
    {
        public int IssueNumber { get; set; }
        public string ReleasePage { get; set; }
        public Magazine() { }

        public Magazine(int id, string name, string publisher, int cateId, string author, int pageNumber,int issueNumber, string releasePage) : base(id, name, publisher, cateId)
        {
            IssueNumber = issueNumber;
            ReleasePage = releasePage;
        }
    }
}
