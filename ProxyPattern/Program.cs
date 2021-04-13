using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User { Role = Role.Author };
            var user2 = new User { Role = Role.Editor };
            var lease = Lease.CreateLease("Inditex Zara", "10 years, percentage rent");
            Console.WriteLine(lease);

            //lease.CompleteReview(user1);
            lease.CompleteReview(user2);


            lease.UpdateName("Inditex", user1);
            Console.WriteLine(lease);

        }
    }
}
