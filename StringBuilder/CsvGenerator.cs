using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CsvGenerator
{
    public class CsvBuilder
    {
        public string GenerateCsv(List<Product> products)
        {
            StringBuilder sb = new StringBuilder();

            // Append the header line
            sb.AppendLine("ProductName,Quantity,Price");

            // Append product data
            foreach (var product in products)
            {
                sb.AppendFormat("{0},{1},{2}", product.ProductName, product.Quantity, product.Price);
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public void SaveCsvToFile(string csvContent, string filePath)
        {
            File.WriteAllText(filePath, csvContent);
        }
    }
}
