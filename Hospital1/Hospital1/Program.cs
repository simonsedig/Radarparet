using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalObjects;

namespace Hospital1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application is running
            bool appRunning = true;
            while (appRunning)
            {
                // create object reference to hospital to store patients
                Business myHospital = new Business();

                // clear any *junk* of previous use of this service
                Console.Clear();


                // read user input and check if input is an integer
                // try
                //  {       
                // call method which welcomes user
                WelcomeUser();

                // read input from user
                int answer = int.Parse(Console.ReadLine());

                // use an -if to take user to his desired service, will call method based on answer
                if (answer == 1)
                {
                    // check for spots for patient
                    for (int i = 0; i < myHospital.patients.Length; i++)
                    {
                        if (myHospital.patients[i] == null)
                        {
                            myHospital.patients[i] = CreatePatient();

                            Console.WriteLine("New patient created!");

                            // allow user to read
                            ActionComplete();
                        }
                        else
                        {
                            // do nothing, continue to find spots with loop
                        }
                    }                   
                }

                else if (answer == 2)
                {
                    // all patients -> SHOW ARRAY SPOT as "id" and then first and last name and age???
                    foreach (var p in myHospital.patients)
                    {
                        Console.WriteLine(p.firstName);
                        Console.WriteLine(p.lastName);
                        Console.WriteLine(p.age);
                        Console.WriteLine(p.conditions);
                        Console.WriteLine(p.currentHospital);
                        Console.WriteLine("\n");
                    }
                    // allow user to read
                    ActionComplete();
                }

                // delete patient
                else if (answer == 3)
                {
                    try
                    {
                        Console.WriteLine("Which patient do you want to delete? Enter array spot!");

                        // fetch user input
                        int deleteArray = int.Parse(Console.ReadLine());

                        // patient deleted
                        myHospital.patients[deleteArray] = null;

                        // display patient deleted for user
                        Console.WriteLine($"Patient has now been dismissed!");     // patient.Fname patient.Lname has been deleted! ??? maybe if possible

                        // allow user to read
                        ActionComplete();
                    }
                    catch
                    {
                        Console.WriteLine("Bad user input");
                    }
                }

                else if (answer == 4)
                {
                    // to be created, transfer patient
                    // hard task to be created

                    // allow user to read
                    ActionComplete();
                }

                else if (answer == 5)
                {
                    Console.WriteLine("Exiting application... Press any key to continue");
                    appRunning = false;
                    Console.ReadLine();
                }

                else
                {
                    // do nothing, catch-block will catch errors
                }
                //}

                // catch
                // {
                Console.WriteLine("Input was not a valid entry, use numbers. Press 'Enter' to return to the main menu.");

                // let user see the message by placing a readline under, so user has to interact to return to main menu
                Console.ReadLine();
                // }

            }

            // app will enter this phase when user enters exit, which will terminate the application
            appRunning = false;
            Environment.Exit(0);
        }

        static public Patient CreatePatient()
        {
            string[] firstName = new string[] { "Jake", "Claire", "Noah", "Louise", "Peter", "Gwen", "Owen", "Blake", "Sandra", "Tresh" };
            string[] lastName = new string[] { "Lane", "Samuelson", "Hansen", "Parker", "Stacy", "O'Brien", "Garfield", "Jackson", "Banner", "Kent" };
            string[] conditions = new string[10];


            Patient patient = new Patient()
            {
                firstName = firstName[RandomDice()],         // assign random first name from existing array
                lastName = lastName[RandomDice()],           // assign random last name from existing array
                age = RandomAge(),                           // assign random age from method    
                conditions = GenerateCondition(conditions),  // generate conditions - set conditions to rnd generate
                currentHospital = "Sacred Heart"             // name for hospital

            };
            return patient;
        }
        // TEST OUT FUNCTIONALITY on loops
        static string[] GenerateCondition(string[] patientConditions)
        {
            // list of conditions to generate
            string[] conditions = new string[] { "Blind", "Fever", "Diabetes", "Physical injury", "Allergy", "Bad breath", "Amnesia", "Lost leg", "Heartache", "Earache" };

            // will give more condition? true first always
            bool giveCondition = true;

            // create chance dice and value - always give one try
            int myDice = 5;

            while (giveCondition)
            {
                if (myDice > 4)
                {
                    // dont add same disease, check if it is there
                    for (int j = 0; j < patientConditions.Length; j++)
                    {
                        // condition to add
                        string newCondition = conditions[RandomDice()];

                        for (int i = 0; i < patientConditions.Length; i++)
                        {
                            // check so same condition is not added
                            while (newCondition == patientConditions[j])
                            {
                                newCondition = conditions[RandomDice()];
                            }

                            // set condition
                            patientConditions[i] = newCondition;

                            // should patient get a new condition? let the dice decide
                            myDice = RandomDice();
                        }

                    }
                }

                // cancel loop if not higher than 4
                else
                {
                    // cancel loop and dont give more conditions to patient
                    giveCondition = false;
                }

            }

            return patientConditions;
        }

        static int RandomAge()
        {
            Random rnd = new Random();
            int age = rnd.Next(0, 100);
            return age;
        }

        static int RandomDice()
        {
            Random rnd = new Random();
            int dice = rnd.Next(0, 9);
            return dice;
        }

        static void WelcomeUser()
        {
            // what does user what to do?
            Console.WriteLine("Welcome to Sacred Heart hospital user interface! What do you wish to do today?");
            Console.WriteLine("Enter the number which represents your service that you wish to use today.");

            // list options...
            Console.WriteLine("1. Create patient");
            Console.WriteLine("2. List patients");
            Console.WriteLine("3. Create patient");
            Console.WriteLine("2. List patients");
            Console.WriteLine("1. Create patient");
            Console.WriteLine("3. Exit");
        }

        static void ActionComplete()
        {
            // allow user to read output
            Console.WriteLine("Request complete. Press any key to continue");
            Console.ReadLine();
        }

    }
}

    namespace HospitalObjects
{
    public class Patient
        {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string[] conditions { get; set; }
        public string currentHospital { get; set; }
        }

        public class Business
        {
            public Patient[] patients { get; set; }
            public string hospitalName = "Sacred Heart";
            public string adress = "12629 Riverside Drive";
            public string city = "North Hollywood";
            public int employees = 50;
        }
}

