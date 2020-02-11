using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smartcom.Models
{
    public class Book
    {
        //id книги
        public int Id { get; set; }
        //название книги
        public string Name { get; set; }
        //атвор книги 
        public string Author { get; set; }
        //цена
        public int Price { get; set; }
    }
}