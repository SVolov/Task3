using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TaskThree.Parts;

namespace TaskThree.Vehicles
{
    public class Vehicle
    {
        public Engine Engine;
        public Chassis Chassis;
        public Transmission Transmission;

        public Vehicle(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Engine:");
            Console.WriteLine($"Power: {Engine.Power}; Volume: {Engine.Volume}; Type: {Engine.Type}; SerialNumber: {Engine.SerialNumber};");
            Console.WriteLine("Chassis:");
            Console.WriteLine($"Wheels: {Chassis.Wheels}; Load: {Chassis.Load}; SerialNumber: {Chassis.SerialNumber};");
            Console.WriteLine("Transmission:");
            Console.WriteLine($"Gear: {Transmission.Gear}; Type: {Transmission.Type}; Manufacturer: {Transmission.Manufacturer};");
        }
    }
}
