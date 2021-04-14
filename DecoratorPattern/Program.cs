using System;

namespace DecoratorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            ILease foodLease = new FoodDecorator(new Lease());
            ILease foodLeaseWithStorage = new StorageDecorator(foodLease);
            ILease foodLeaseWithStorageAndOffice = new OfficeDecorator(foodLeaseWithStorage);
            ILease leaseWithOfficeAndStorageNonFood = new NonFoodDecorator(new StorageDecorator(new OfficeDecorator(new Lease())));


            Console.WriteLine(foodLease.GetLeaseType());
            Console.WriteLine(foodLeaseWithStorage.GetLeaseType());
            Console.WriteLine(foodLeaseWithStorageAndOffice.GetLeaseType());
            Console.WriteLine(leaseWithOfficeAndStorageNonFood.GetLeaseType());
        }
    }
}
