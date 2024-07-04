using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace InventoryManagement
{
    public class OrderItem
    {

      
public int id { get; set; }

public int ProductId { get; set; }
public string ProductName { get; set; } = string.Empty;
public int AmountOrdered { get; set; }  

public override string ToString()
{

return $"Product ID: {ProductId} - Name: {ProductName} - Amount ordered: {AmountOrdered}";


}

    }
    
    }