using System;

namespace ECommerceSystem
{
    // Base class
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Virtual method
        public virtual decimal CalculateDiscount()
        {
            // Default discount logic (e.g., 5% for all products)
            return Price * 0.05m;
        }

        public void DisplayPriceAfterDiscount()
        {
            decimal discount = CalculateDiscount();
            decimal finalPrice = Price - discount;
            Console.WriteLine($"{Name} - Original Price: ${Price}, Discount: ${discount}, Final Price: ${finalPrice}");
        }
    }

    // Derived class for Electronics
    public class Electronics : Product
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        // Override method with specific discount logic for electronics
        public override decimal CalculateDiscount()
        {
            // Electronics have a 10% discount
            return Price * 0.10m;
        }
    }

    // Derived class for Clothing
    public class Clothing : Product
    {
        public string Size { get; set; }
        public string Color { get; set; }

        // Override method with specific discount logic for clothing
        public override decimal CalculateDiscount()
        {
            // Clothing has a 15% discount
            return Price * 0.15m;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of products
            Product laptop = new Electronics { Name = "Laptop", Price = 1000.00m, Brand = "BrandA", Model = "ModelX" };
            Product shirt = new Clothing { Name = "Shirt", Price = 50.00m, Size = "M", Color = "Blue" };

            // Displaying price after discount
            laptop.DisplayPriceAfterDiscount();
            shirt.DisplayPriceAfterDiscount();

            Console.ReadLine();
        }
    }
}
