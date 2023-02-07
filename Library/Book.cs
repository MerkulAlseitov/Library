using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book : ILabraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool CheckedOut { get; set; }
        public Book(string title, string author, string isbn, bool checkedout) 
        {
            Title = title;
            Author = author;
            ISBN= isbn;
            CheckedOut = checkedout;
        }
        
        public void CheckOut()
        {
            CheckedOut = true;
        }
 
        public void CheckIn()
        {
            CheckedOut= false;
        }

    }

}
