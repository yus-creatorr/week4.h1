// interface IVehicle
// {
//     void Drive();
//     bool Refuel(int amount);
// }

// class Car : IVehicle
// {
//     private int gasoline;

//     public Car(int startGasoline)
//     {
//         gasoline = startGasoline;
//     }

//     public void Drive()
//     {
//         if (gasoline > 0)
//         {
//             Console.WriteLine("Driving");
//         }
//         else
//         {
//             Console.WriteLine("No gasoline");
//         }
//     }

//     public bool Refuel(int amount)
//     {
//         gasoline += amount;
//         return true;
//     }
// }







// class Program
// {
//     static void Main()
//     {
//         Car car = new Car(0);

//         Console.Write("Enter gasoline amount: ");
//         int amount = Convert.ToInt32(Console.ReadLine());

//         car.Refuel(amount);
//         car.Drive();
//     }
// }