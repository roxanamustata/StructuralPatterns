using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Lease
    {


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


        internal virtual void CompleteReview(User editor)
        {
            DateReviewed = DateTime.UtcNow;
        }

        internal virtual void UpdateName(string newName, User user)
        {
            Name = newName;
        }

    }
}
