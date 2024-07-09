using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvGenerator;

namespace CsvGeneratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("Apple", 50, 0.5m),
                new Product("Banana", 100, 0.3m),
                new Product("Cherry", 200, 0.2m)
            };

            CsvBuilder csvBuilder = new CsvBuilder();
            string csvContent = csvBuilder.GenerateCsv(products);

            // Output the CSV content to console
            Console.WriteLine(csvContent);

            // Save the CSV content to a file
            string filePath = "products.csv";
            csvBuilder.SaveCsvToFile(csvContent, filePath);

            Console.WriteLine($"CSV file saved to {filePath}");
        }
    }
}
