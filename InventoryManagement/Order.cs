using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace InventoryManagement
{
    public class Order
    {
public int id { get; private set; }
public DateTime OrderFulfilmentDate {get; private set; }
public List<OrderItem>OrderItems{get;}

public bool Fulfilled {get;set;}

//constructor
public Order()
{
id = new Random().Next(9999999);
int numberOfSeconds = new Random().Next(100);
OrderFulfilmentDate = DateTime.Now.AddSeconds(numberOfSeconds);
OrderItems = new List<OrderItem>();

}

    }
}