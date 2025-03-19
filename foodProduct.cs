using System;


namespace inheritance_exercise
{
    class FoodProduct : Product
    {
        private string _foodCategory;

        public string FoodCategory
        {
            get { return _foodCategory; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _foodCategory = value;
                }
                else
                {
                    Utils.showError("Food category cannot be empty");
                    throw new ArgumentException("Food category cannot be empty.");
                }
            }
        }
        public FoodProduct(string name, string description, double price, string foodCategory)
            : base(name, price, description, "food")
        {
            FoodCategory = foodCategory;
        }

        public override string GetDetails()
        {
            string details = base.GetDetails() + $"\nFood Category: {_foodCategory}";
            return details;
        }



    }
}
