using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaseFacade = new LeaseFacade();
            leaseFacade.GenerateLease();
            Console.WriteLine("-------------------");
            leaseFacade.SetClauses();
           
        }
    }
}
