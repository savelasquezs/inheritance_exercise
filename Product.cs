using System;

namespace inheritance_exercise
{
    class Product
    {
        private string _name;
        private double _price;
        private string _description;
        private string _category;

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    Utils.showError("Name cannot be empty.");
                    throw new ArgumentException("Name cannot be empty.");
                }
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    Utils.showError("Price cannot be negative.");
                    throw new ArgumentException("Price cannot be negative.");
                }
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _description = value;
                }
                else
                {
                    Utils.showError("Description cannot be empty.");
                    throw new ArgumentException("Description cannot be empty.");
                }
            }
        }

        public string Category
        {
            get { return _category; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _category = value;
                }
                else
                {
                    Utils.showError("Category cannot be empty.");
                    throw new ArgumentException("Category cannot be empty.");
                }
            }
        }

        public Product(string name, double price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }

        public virtual string GetDetails()
        {
            string details = $@"
Name: {Name},
Price: ${Price}
Category: {Category}
Description: {Description}";

            return details;
        }
    }
}
