using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Books : IComparable
    {
        private string ISBN;
        private string title;
        private string author;
        

        public Books(string ISBN, string title, string author)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string isbn
        {
            get { return ISBN; }
            set { ISBN = value; }
        }

        public int CompareTo(Object obj) //implementation of CompareTo
        {

            Books other = (Books)obj;
            return ISBN.CompareTo(other.ISBN);
        }
        public string GetSummary()
        {
            string summary = (Title + ", " + author + ", " + ISBN);
            return summary;
        }


    }
}

