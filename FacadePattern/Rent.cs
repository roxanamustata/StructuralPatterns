using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
   public class Rent:LeaseComponent
    {
        public void Set()
        {
            Console.WriteLine("Rent is set");

        }
    }
}
