using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Product
    {

      /* the string? in description field means that it can be left empty
      string.Empty = the name can be empty
      */  
      //private fields for product details and stock management
private int id;
private string name = string.Empty;
private string? description;
private int maxItemsInStock = 0;
private int amountInStock = 0;
private bool isBelowStockThreshold = false;

//public method to use a specified number of items from stock
public void UseProduct(int items)
{

if (items <= amountInStock)
{
    //decrease the stock and update the low stock status
amountInStock-=items;

UpdateLowStock();
Log($"Amount in stock updated. Now {amountInStock} items in stock");

}

else 
{
    //log an error msg if not enough items are in stock
Log($"Not enough items on stock for{CreateSimpleProductRepresentation()}. {amountInStock} available but {items} requested");
}
}


public void IncreaseStock()
{
amountInStock++;

}
//method to decrease the stock ny a specified number of items with a reason

private void DecreaseStock(int items, string reason)
{
if (items <= amountInStock)
{
    //decreasing the stock
    amountInStock-= items;
}
else 
{
    //if not enough items, set stock to zero
amountInStock = 0;

}
UpdateLowStock();
Log (reason);

}
//method to create a simple string representation of the product
private string CreateSimpleProductRepresentation()
{
    return $"Product {id} ({name})";
}

//method to log a msg to the console
private void Log(string message)
{
Console.WriteLine(message);

}

//method to display full details of the product
public string DisplayDetailsFull()
{

StringBuilder sb = new();
sb.Append($"{id}  {name} \n{description}\n{amountInStock} item(s) in stock");

if (isBelowStockThreshold){
    sb.Append("\n !!LOW STOCK");
}

return sb.ToString();
}

//method to update the low stock status
private void UpdateLowStock()
{
if (amountInStock <= 10) // fixed threshold for low stock
{
isBelowStockThreshold = true;

}

}

}

    }


