using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy_stt39_PhanLeVanMinh_333
{
    internal class Book:Document
    {
        public string Author { get; set; }
        public int PageNumber { get; set; }
        public Book() { }
        public Book(int id, string name, string publisher, int cateId, string author, int pageNumber) : base(id, name, publisher,cateId)
        {
            Author = author;
            PageNumber = pageNumber;
        }
    }
}
