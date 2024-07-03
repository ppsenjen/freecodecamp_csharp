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
private int id;
private string name = string.Empty;
private string? description;
private int maxItemsInStock = 0;
private int amountInStock = 0;
private bool isBelowStockThreshold = false;


public void UseProduct(int items)
{

if (items <= amountInStock)
{
//use the items
amountInStock-=items;

UpdateLowStock();
Log($"Amount in stock updated. Now {amountInStock} items in stock");

}

else 
{
Log($"Not enough items on stock for{CreateSimpleProductRepresentation()}. {amountInStock} available but {items} requested");
}
}


public void IncreaseStock()
{
amountInStock++;

}

private void DecreaseStock(int items, string reason)
{
if (items <= amountInStock)
{
    //decreasing the stock
}

}

private string CreateSimpleProductRepresentation()
{
    return $"Product {id} ({name})";
}

private void Log(string message)
{
Console.WriteLine(message);

}


private void UpdateLowStock()
{
if (amountInStock <= 10) // for now 10 is fixed
{
isBelowStockThreshold = true;

}

}

}

    }


