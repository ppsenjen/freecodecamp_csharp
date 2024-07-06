using InventoryManagement;

namespace Utilities
{

class Utilities

{
private static List<Product> inventory = new();
private static List<Order> orders = new();

internal static void initializeStock()
{
Product p1 = new Product(1, "Sugar", "Tasty", new Price () {ItemPrice=10,Currency= Currency.Shillings},UnitType.PerItem, 100);
Product p2 = new Product(1, "Strawberry", "yummy", new Price () {ItemPrice=8,Currency= Currency.Dollar},UnitType.PerItem, 20);
Product p3 = new Product(1, "Indomie", "delicious", new Price () {ItemPrice=3,Currency= Currency.Euro},UnitType.PerItem, 10);
inventory.Add(p1);
inventory.Add(p2);
inventory.Add(p3);

}
internal static ShowMainMenu()
{
Console.ResetColor();
Console.Clear();
Console.WriteLine("***************");
Console.WriteLine("*Select an action*");
Console.WriteLine("******************");


Console.WriteLine("1: Inventory Management");
Console.WriteLine("2: Order Management");
Console.WriteLine("3:  settings");
Console.WriteLine("4: Save all data");
Console.WriteLine("0: Close Application");


Console.WriteLine("Your Selection");

string? userSelection = Console.ReadLine();
switch(userSelection){
    case "1":
    ShowInventoryManagementMenu();
    break;
    case "2":
    ShowOrderManagement();
    break;
    case "3":
    ShowSettingMenu();
    break;
    case "4":
    break;
    case "0":
    break;
    default:
    Console.WriteLine("Invalid selection.Please try again.");
    break;
}

}
private static void ShowInventoryManagementMenu()
{
string? userSelection;
do
{
Console.ResetColor();
Console.Clear();
Console.WriteLine("***************");
Console.WriteLine("*Inventory Management*");
Console.WriteLine("******************");

ShowAllProductsOverview();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("What do you want to do?");
    Console.ResetColor();

Console.WriteLine("1: View details of product");
Console.WriteLine("2: Add new product");
Console.WriteLine("3: Clone product");
Console.WriteLine("4: View products with low stock");
Console.WriteLine("0: Back to the main menu");

Console.Write("Your selection");
userSelection = Console.ReadLine();

switch (userSelection)
{
case "1":
    ShowDetailsAndUseProduct();
    break;
    case "2":
    //CreateNewProduct();
    break;
    case "3":
    //ShowCloneExistingProduct();
    break;
    case "4":
    ShowProductsLowOnStock();
     break;
      default:
      Console.WriteLine("Invalid Selection.Please try again.");
      break ;
}

} 
while (userSelection != "0");

ShowMainMenu();

}

private static void ShowAllProductsOverview ()
{

foreach (var product in inventory)
{
Console.WriteLine(product.DisplayDetailsShort);
Console.WriteLine();
}
}

private static void ShowDetailsAndUseProduct (){
    string? userSelection = string.Empty;
Console.Write("Enter the ID of product: ");
string? selectionProductId = Console.ReadLine ();

if (selectionProductId != null)
{

Product? selectedProduct = inventory.Where(p => p.Id == int.Parse(selectionProductId)).FirstOrDefault();
if (selectedProduct != null)
{

Console.WriteLine(selectedProduct.DisplayDetailsFull());

Console.WriteLine("/n What do you want to do?");
Console.WriteLine("1: Use product");
Console.WriteLine("0: Back to inventory overview");

Console.Write("Your selection");
userSelection = Console.ReadLine ();




}

}
    
}



}

}


