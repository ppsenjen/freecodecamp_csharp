using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bus
{

public class BusRoutes
{
public int Number { get;  }
public string Destination{ get;  }

public int Origin { get;  }

//Constructor
public BusRoutes(int number, string destination, int origin)
{
this.Number = number;
this.Destination = destination;
this.Origin = origin;
}

//public override string ToString() => $"{Number}: {Origin} ->{Destination}";

}
}