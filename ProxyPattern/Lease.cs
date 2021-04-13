using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Lease
    {
        // A static factory method that returns a protected proxy around the lease
        public static Lease CreateLease(string name, string content)
        {
            return new ProtectedLease(name, content);
        }

        protected Lease(string name, string content)
        {
            Name = name;
            Content = content;
        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Content { get; private set; }

        public DateTime DateCreated { get; private set; } = DateTime.UtcNow;
        public DateTime DateReviewed { get; private set; }


        // Two methods for updating the lease:

        internal virtual void CompleteReview(User editor)
        {
            DateReviewed = DateTime.UtcNow;
        }

        internal virtual void UpdateName(string newName, User user)
        {
            Name = newName;
        }

        public override string ToString()
        {
            return $"Name: {Name},\nContent: {Content},\nCreated at: {DateCreated},\nReviewed at: {DateReviewed}";
        }
    }
}
