using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class FoodDecorator:LeaseDecorator
    {

        public FoodDecorator(ILease lease) : base(lease) { }

        public override string GetLeaseType()
        {
            return $"{base.GetLeaseType()} food |";
        }
    }
}
