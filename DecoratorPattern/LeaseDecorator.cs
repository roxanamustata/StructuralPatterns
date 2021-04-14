using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class LeaseDecorator : ILease
    {

        private ILease _lease;

        public LeaseDecorator(ILease lease)
        {
            _lease = lease;
        }
        public virtual string GetLeaseType()
        {
            return _lease.GetLeaseType();
        }
    }
}
