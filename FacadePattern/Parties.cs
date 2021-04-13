using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
   public class Parties:LeaseComponent
    {
  
        public void Set()
        {
            Console.WriteLine("Parties are set");
        }

    }
}
