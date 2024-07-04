using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

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




//properties prevent direct entry to the private data
//A property to get access to the id of the product
//or setting it
public int Id
 {
get {return id;}
set {id = value;}

}

//A property for the Name 
//set checks if the value entered in 50 or more
//only the first 50 will be used else it will be truncated
// [..50] is the range operator which will take values until 50
public string Name 
{
    get {return name;}
    set {name = value.Length >50? value [..50] : value;}
}

//property for the description
public string? Description 
{

get {return description;}
set{
if (value == null)
{
description = string.Empty;

}
else 
{
description = value.Length >250 ? value[..250] : value ;

}
}
}


//Automatic properties for unit type
//AmountInStock
//IsBelowStockThreshold

public UnitType UnitType {get;set;}
//private set = the value is available for use inside the class
//but not from the outside (read only)
public int AmountInStock { get; private set;}

public bool IsBelowStockThreshold{get;private set;}
public Price Price {get; set;}

//constructor overloading using (this) to invoke another constructor
    public Product(int id) : this(id, string.Empty)
    {

    }

public Product (int id, string name)
{
this.id = id;
this.name = name;

}

public Product (int id, string name, string? description,Price price, UnitType unitType, int amountInStock)
{
Id = id;
Name = name;
Description = description;
Price = price;
UnitType = unitType;
AmountInStock = amountInStock;

UpdateLowStock();


}

//public method to use a specified number of items from stock
public void UseProduct(int items)
{

if (items <= AmountInStock)
{
    //decrease the stock and update the low stock status
AmountInStock-=items;

UpdateLowStock();
Log($"Amount in stock updated. Now {AmountInStock} items in stock");

}

else 
{
    //log an error msg if not enough items are in stock
Log($"Not enough items on stock for{CreateSimpleProductRepresentation()}. {AmountInStock} available but {items} requested");
}
}

//overloading IncreaseStock method
public void IncreaseStock()
{
AmountInStock++;
UpdateLowStock();

}
public void IncreaseStock(int amount)
{
int newStock = AmountInStock + amount;

if (newStock <= maxItemsInStock )
{
AmountInStock += amount;


}
else {
    AmountInStock = maxItemsInStock; //storing only the possible items  overstocking is not allowed
    Log ($"{CreateSimpleProductRepresentation} stock overflow. {newStock - AmountInStock}   item(s)  ordered that could'nt be stored");
}

if(AmountInStock > 10) {
    IsBelowStockThreshold = false;
}

}

//method to decrease the stock ny a specified number of items with a reason

private void DecreaseStock(int items, string reason)
{
if (items <= AmountInStock)
{
    //decreasing the stock
    AmountInStock-= items;
}
else 
{
    //if not enough items, set stock to zero
AmountInStock = 0;

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

/*StringBuilder sb = new();
sb.Append($"{id}  {name} \n{description}\n{Price}\n{AmountInStock} item(s) in stock");

if (IsBelowStockThreshold)
{
    sb.Append("\n !!LOW STOCK");
}

return sb.ToString(); */
return DisplayDetailsFull("");   //alternative to the above

}

//overload of DisplayDetailsFull
public string DisplayDetailsFull (string extraDetails)
{
StringBuilder sb = new StringBuilder();
sb.Append($"{id}  {name} \n{description}\n{Price}\n{AmountInStock} item(s) in stock");
sb.Append (extraDetails);

if (IsBelowStockThreshold)
{
sb.Append("!!LOW STOCK");

}
return sb.ToString();
}


//method to update the low stock status
private void UpdateLowStock()
{
if (AmountInStock <= 10) // fixed threshold for low stock
{
IsBelowStockThreshold = true;

}

}

}

    }


