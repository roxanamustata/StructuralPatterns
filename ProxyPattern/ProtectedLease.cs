using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    // Protective proxy manages access to a resource based on authorization rules (acts as a gatekeeper around a resource)
    
    public class ProtectedLease : Lease
    {
       
        public ProtectedLease(string name, string content) : base(name, content)
        {

        }

        // User has to be an editor to review the lease
        internal override void CompleteReview(User user)
        {
            if (user.Role != Role.Editor)
            {
                throw new UnauthorizedAccessException("Can not review lease unless you are editor");
            }
            base.CompleteReview(user);
            Console.WriteLine("Lease reviewed");
        }

        // User has to be the author to change lease name
        internal override void UpdateName(string newName, User user)
        {
            if (user.Role != Role.Author)
            {
                throw new UnauthorizedAccessException("Can not update name unless you are author");
            }
            base.UpdateName(newName, user);
            Console.WriteLine("Name updated");
        }
    }
}
