
// using System;

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



// Task 2



// abstract class Animal
// {
//     public string Name { get; set; }

//     public void SetName(string name)
//     {
//         Name = name;
//     }

//     public string GetName()
//     {
//         return Name;
//     }

//     public abstract void Eat();
// }

