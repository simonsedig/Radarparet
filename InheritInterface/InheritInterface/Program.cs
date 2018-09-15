using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // program running
            bool programRunning = true;

            // create garage and viewer
            Garage myGarage = new Garage();            

            // do this while running
            while (programRunning)
            {
                // clear previous conversations
                Console.Clear();

                // introduction
                Introduction();

                try
                {
                    // what do user want to do today?
                    int answer = int.Parse(Console.ReadLine());                

                    // dont let user type to high number
                    if (answer > 4 || answer < 1)
                    {
                        Console.WriteLine("Woooah! I can't process that high/low of a number.. I'm not a machine.. oh wait I am..\n");
                        // throw error
                        ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException("answer", "Ah, great.. now I'm gonna space out.. OVERLOAD!");
                        Console.WriteLine(ex.Message);

                        // allow to read
                        Console.ReadLine();
                    }
                    // correct user input? continue
                    else
                    {
                        switch (answer)
                        {

                            case 1:
                                {
                            
                                    // ask user which garage spot he wants to look at
                                    Console.WriteLine($"Which garage spot do you wish to look at? {myGarage.vehicles.Length} vehicles available, spot 0-4");

                                    // let user read
                                    int garageSpot = int.Parse(Console.ReadLine());

                                    GarageViewer.ShowGarage(garageSpot);
                                    break;
                                }

                            case 2:
                                {
                                    break;
                                }

                            case 3:
                                {
                                    programRunning = false;
                                    Console.WriteLine("Jeeves bid you farewell, cya later human!");
                                    Console.ReadLine();
                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("... yeah.. this is probably not going to run..");
                                    break;
                                }

                        }
                    }

                }
                catch
                {
                    Console.WriteLine("Did I space out again? I'm sorry... I don't speak human very wells.");

                    // allow user to read
                    Console.ReadLine();
                }

            }
        }
        static void Introduction()
        {
            Console.WriteLine("Welcome to the garage! \nWhat do you wish to do today?.. Jeeves only understands numbers!");

            Console.WriteLine("1. View item in garage.");
            Console.WriteLine("2. Do that");
            Console.WriteLine("3. Exit program");
        }
    }

    class Garage
    {
        // create garage spots
        public Vehicle[] vehicles = new Vehicle[5];

        public Garage()
        {
            Car car1 = new Car("Spider X", "2000");
            Car car2 = new Car("Spider Y", "4000");
            Car car3 = new Car();
            Truck truck1 = new Truck("Americano Truck", "StrongHold 2000");
            Truck truck2 = new Truck("Rich Desert", "Nitro X");

            vehicles[0] = car1;
            vehicles[1] = car2;
            vehicles[2] = car3;
            vehicles[3] = truck1;
            vehicles[4] = truck2;
        }

    }

    // static class to view specific car in garage
    public static class GarageViewer 
    {
        public static void ShowGarage(int whichCar)
        {
            if (whichCar < 0 || whichCar > 4)
            {
                Console.WriteLine("Dont you wish you had that many cars too?...");
                Console.ReadLine();
            }
            else
            {
                // create garage, obj will create in const.
                Garage garage = new Garage();


                // write vehicle spec.
                Console.WriteLine("\n---------------\n");

                Console.WriteLine(garage.vehicles[whichCar].GetName());
                Console.WriteLine(garage.vehicles[whichCar].GetModell());
                Console.WriteLine(garage.vehicles[whichCar].GetHorsePower());
                Console.WriteLine(garage.vehicles[whichCar].GetAmountWheel());

                Console.WriteLine("\n---------------\n");

                // let user read
                Console.ReadLine();
            }
        }
    }

    public class Vehicle
    {
        public string name;
        public string modell;

        public int horsePower;
        public int amountWheels;

        public string GetName()
        {
            return name;

        }
        public string GetModell()
        {
            return modell;
        }

        public int GetHorsePower()
        {
            return horsePower;
        }
        public int GetAmountWheel()
        {
            return amountWheels;
        }
    }

    class Car : Vehicle
    {
        // standard car by const.
        public Car()
        {
            name = "SuperPowerConstrucTION";
            modell = "madeByConstructorSTANDARD";
            horsePower = 200;
            amountWheels = 4;
        }
        // user can pick name and modell /w const.
        public Car(string name, string modell)
        {
            this.name = name;
            this.modell = modell;
            this.horsePower = 280;
            this.amountWheels = 4;
        }
    }
    class Truck : Vehicle
    {
        // standard truck, not used
        public Truck()
        {
            horsePower = 200;
            amountWheels = 4;
        }
        // user can pick name and modell /w const.
        public Truck(string name, string modell)
        {
            this.name = name;
            this.modell = modell;
            this.horsePower = 240;
            this.amountWheels = 4;
        }
    }
    // not used
    class Boat
    {
        public string boatName;
        public string boatModel;

        public int waterSpeed = 190;
        public bool hasWheels = false;

        public Boat()
        {
            boatName = "StenaLine";
            boatModel = "SpendYoMoneyOnSlots";
        }
    }
}