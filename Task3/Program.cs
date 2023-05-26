using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using System.Threading.Tasks;
using TaskThree.Parts;
using TaskThree.Vehicles;

class Program
{
    static void Main(string[] args)
    {
        Engine eninerCar = new Engine(125, 2.5, "Petrol", 123456);
        Chassis chassisCar = new Chassis(4, 654321, 2);
        Transmission transmissionCar = new Transmission("AUTO", 7, "GERMANY");
        Car car = new Car(eninerCar, chassisCar, transmissionCar, 6.0);
        car.PrintInfo();

        Engine eninerBus = new Engine(250, 3.0, "Diesel", 756546);
        Chassis chassisBus = new Chassis(4, 567891, 4);
        Transmission transmissionBus = new Transmission("MANUAL", 6, "BELARUS");
        Bus bus = new Bus(eninerBus, chassisBus, transmissionBus, 35);
        bus.PrintInfo();

        Engine eninerLorry = new Engine(400, 3.5, "Diesel", 974652);
        Chassis chassisLorry = new Chassis(6, 234876, 30);
        Transmission transmissionLorry = new Transmission("MANUAL", 5, "NORWAY");
        Lorry lorry = new Lorry(eninerLorry, chassisLorry, transmissionLorry, 20);
        lorry.PrintInfo();

        Engine eninerScooter = new Engine(45, 0.5, "Petrol", 324629);
        Chassis chassisScooter = new Chassis(2, 027552, 1);
        Transmission transmissionScooter = new Transmission("AUTO", 4, "JAPAN");
        Scooter scooter = new Scooter(eninerScooter, chassisScooter, transmissionScooter, 2);
        scooter.PrintInfo();
    }
}

