using System;

namespace AccessModifiers
{
    // Access Modifiers control how properties and methods are accessed
    class Book
    {
        // TODO: "public" members and methods can be access by anython other code in the program
        // NOTE: This is not the right way to expose interal data
        public string _name;

        // TODO: "protected" members can only be accessed by the class or a derived class from this one
        protected string _author;

        // TODO: "private" is the default and can only be accessed by code within the class
        private int _pagecount;

        public Book (string Name, string Author, int Pages)
        {
            _name = Name;
            _author = Author;
            _pagecount = Pages;
        }

        public string GetDescription()
        {
            return $"{_name} by {_author}, {_pagecount} pages.";
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string n)
        {
            _name = n;
        }
        public string GetAuthor()
        {
            return _author;
        }
        public void SetAuthor(string n)
        {
            _author = n;
        }
        public int GetPages()
        {
            return _pagecount;
        }
        public void SetPages(int p)
        {
            _pagecount = p;
        }
    }
}