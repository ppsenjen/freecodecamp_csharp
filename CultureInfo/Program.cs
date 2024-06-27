using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Simulate different user cultures
        List<string> userCultures = new List<string> { "en-US", "fr-FR", "de-DE" };

        foreach (var cultureName in userCultures)
        {
            CultureInfo userCulture = new CultureInfo(cultureName);
            DisplayLocalizedInfo(userCulture);
        }

        // Parsing user input according to culture
        string userInput = "12/31/2023"; // User input in MM/DD/YYYY format
        ParseDateInput(userInput, "en-US");

        userInput = "31/12/2023"; // User input in DD/MM/YYYY format
        ParseDateInput(userInput, "fr-FR");
    }

    static void DisplayLocalizedInfo(CultureInfo culture)
    {
        DateTime currentDate = DateTime.Now;
        double price = 1234.56;

        // Format date
        string formattedDate = currentDate.ToString("D", culture);
        // Format price
        string formattedPrice = price.ToString("C", culture);

        Console.WriteLine($"Culture: {culture.DisplayName}");
        Console.WriteLine($"Formatted Date: {formattedDate}");
        Console.WriteLine($"Formatted Price: {formattedPrice}");
        Console.WriteLine();
    }

    static void ParseDateInput(string input, string cultureName)
    {
        CultureInfo culture = new CultureInfo(cultureName);
        if (DateTime.TryParse(input, culture, DateTimeStyles.None, out DateTime parsedDate))
        {
            Console.WriteLine($"Successfully parsed date '{input}' as {parsedDate.ToShortDateString()} using culture {cultureName}");
        }
        else
        {
            Console.WriteLine($"Failed to parse date '{input}' using culture {cultureName}");
        }
        Console.WriteLine();
    }
}
