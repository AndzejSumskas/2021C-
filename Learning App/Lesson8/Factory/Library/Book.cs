using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson8.Factory.Library
{
    class Book
    {
        private string name;
        private Author author;
        private DateTime publishetdate;

        public Book(string name, Author author, DateTime publishetdate)
        {
            this.name = name;
            this.author = author;
            this.publishetdate = publishetdate;
        }

        public string GetName()
        {
            return name;
        }
    }
}
