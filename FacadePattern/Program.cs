using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaseFacade = new LeaseFacade();
            leaseFacade.SetClauses();
            leaseFacade.SetParties();
            leaseFacade.SetRent();
            leaseFacade.SetPremises();
        }
    }
}
