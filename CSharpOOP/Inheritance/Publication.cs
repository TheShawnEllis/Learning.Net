using System;
using static System.Console;

namespace Inheritance
{
    class Publication
    {   
        // Fields
        private string _name;

        // Constructor
        public Publication(string name, int pagecount, decimal price)
        {
            _name = name;
            PageCount = pagecount;
            Price = price;
        }

        // The PageCount & Price property has no backing field
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public string Name
        {
            // Return the name
            get { return _name; }
            // Use the setter to validate the new property value
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be blank.");
                }
                else
                {
                    _name = value;
                }
            }
        }

        // TODO: Use 'virtual' keyword to indicate that a method can
        // be overritten by subclass to customize behavor
        public virtual string GetDescription()
        {
            return $"{Name}, {PageCount} pages";
        }
    }
}