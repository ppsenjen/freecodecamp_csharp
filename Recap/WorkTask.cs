using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
   struct WorkTask
   {
public string description;
public int hours;

public void PerfomWorkTask(){
    Console.WriteLine($"Task {description} of {hours} hours has been performed ") ;
}

   }
   }
