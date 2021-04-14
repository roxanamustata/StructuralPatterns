using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class NonFoodDecorator:LeaseDecorator
    {
        public NonFoodDecorator(ILease lease) : base(lease) { }

        public override string GetLeaseType()
        {
            return $"{base.GetLeaseType()} non-food |";
        }
    }
}
