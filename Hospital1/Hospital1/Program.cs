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
            // application is running
            bool appRunning = true;

            // create object reference to hospital to store patients   
            Business business = new Business();         

            // create person
            Patient patient0 = new Patient();
            Patient patient1 = new Patient();
            Patient patient2 = new Patient();
            Patient patient3 = new Patient();
            Patient patient4 = new Patient();

            // call method to assign attibutes to patients
            CreatePatient(patient0);
            CreatePatient(patient1);
            CreatePatient(patient2);
            CreatePatient(patient3);
            CreatePatient(patient4);

            // put patient in business - patients array
            business.patients[0] = patient0;
            business.patients[1] = patient1;
            business.patients[2] = patient2;
            business.patients[3] = patient3;
            business.patients[4] = patient4;

            while (appRunning)
            {                     
                // clear any *junk* of previous use of this service
                Console.Clear();

                // call method which welcomes user
                WelcomeUser();

                // read input from user
                int answer = int.Parse(Console.ReadLine());

                // use an -if to take user to users desired service, will call method based on answer

                if (answer == 1)
                {
                    // show all patients
                    foreach (var p in business.patients)
                    {
                        Console.WriteLine("-------------------------------");

                        Console.WriteLine($"First name: {p.firstName}");
                        Console.WriteLine($"Last name: {p.lastName}");
                        Console.WriteLine($"Age: {p.age}");

                        // write conditions with loop
                        Console.WriteLine("\nCurrent conditions: ");

                        // write out for the patients
                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write($"{p.conditions[i]}, ");
                        }
                                                                       
                        // create space after loop - readabillity
                        Console.WriteLine("\n");

                        Console.WriteLine($"Current hospital: {p.currentHospital}");

                        Console.WriteLine("-------------------------------");

                        Console.WriteLine("\n");                      
                    }

                    // allow user to read
                    ActionComplete();
                }

                else if (answer == 2)
                {
                    // to be created, transfer patient
                    // hard task to be created

                    // allow user to read
                    ActionComplete();
                }

                else if (answer == 3)
                {
                    Console.WriteLine("Exiting application... Press any key to continue");
                    appRunning = false;
                    Console.ReadLine();
                }

                else
                {
                    // do nothing, catch-block will catch errors
                }

            }

            // app will enter this phase when user enters exit, which will terminate the application
            appRunning = false;
            Environment.Exit(0);
        }

        static public Patient CreatePatient(Patient p)
        {
            string[] firstName = new string[] { "Jake", "Claire", "Noah", "Louise", "Peter", "Gwen", "Owen", "Blake", "Sandra", "Tresh" };
            string[] lastName = new string[] { "Lane", "Samuelson", "Hansen", "Parker", "Stacy", "O'Brien", "Garfield", "Jackson", "Banner", "Kent" };
            string[] conditions = new string[10];

            p.firstName = firstName[RandomDice()];         // assign random first name from existing array
            p.lastName = lastName[RandomDice()];           // assign random last name from existing array
            p.age = RandomAge();                           // assign random age from method    
            p.conditions = GenerateCondition(conditions);  // generate conditions - set conditions to rnd generate
            p.currentHospital = "Sacred Heart";            // name for hospital

            return p;
        }
        
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
                    for (int i = 0; i < patientConditions.Length; i++)
                    {
                        // condition to add
                        string newCondition = conditions[RandomDice()];

                        for (int k = 0; k < patientConditions.Length; k++)
                        {
                            // check so same condition is not added
                            while (newCondition == patientConditions[k])
                            {
                                newCondition = conditions[RandomDice()];
                            }                        

                            // should patient get a new condition? let the dice decide
                            myDice = RandomDice();
                        }

                        // set condition
                        patientConditions[i] = newCondition;
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
            Console.WriteLine("1. List patients");
            Console.WriteLine("2. Transfer patients");
            Console.WriteLine("3. Exit");
        }

        static void ActionComplete()
        {
            // allow user to read output
            Console.WriteLine("Request complete. Press any key to continue");
            var waitCommand = Console.ReadLine();
        }

        //Counts the amount of patients in the hospital
        static int CountPatients(Patient[] x)
        {
            return x.Length;
        }

        //CountPatients with ref argument makes permanent changes to x variable to keep track of the patients
        static int CountPatients(ref int x)
        {
            x--;
            return x;
        }
    }
}

    namespace HospitalObjects
{
    public class Patient
        {
            public string firstName;
            public string lastName;
            public int age;
            public string[] conditions;
            public string currentHospital;
        }

        public class Business
        {
            public Patient[] patients = new Patient[5];
            public string hospitalName = "Sacred Heart";
            public string adress = "12629 Riverside Drive"; 
            public string city = "North Hollywood";
            public int employees = 50;
        }
}

