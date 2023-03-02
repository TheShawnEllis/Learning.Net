using System;
using static System.Console;

namespace Inheritance
{
    // TODO: Declaring "Magazine" as a subclass of Publication
    class Magazine : Publication
    {
        private string _publisher;

        // TODO: Use the base() keyword to initialize the base class
        public Magazine(string name, string publisher, int pagecount, decimal price)
        : base(name, pagecount, price)
        {
            _publisher = publisher;
        }

        public string Publisher 
        {
            get => _publisher;
            set => _publisher = value;
        }
    }
}