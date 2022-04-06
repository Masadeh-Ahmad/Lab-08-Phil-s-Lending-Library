using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Book
    {
        public string title { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int numberOfpages { get; set; }

        public Book(string title , string firstname ,string lastname,int numberOfpages)
        {
            this.title = title; 
            this.firstname = firstname; 
            this.lastname = lastname;
            this.numberOfpages = numberOfpages;
        }
    }

}
