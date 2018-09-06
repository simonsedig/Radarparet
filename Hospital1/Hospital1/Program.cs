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
                //Create patients
            }

            appRunning = false;
            Environment.Exit(0);
        }

        static Patient CreatePatient()
        {
            string[] firstName = new string[] { "Jake", "Claire", "Noah", "Louise", "Peter", "Gwen", "Owen", "Blake", "Sandra", "Tresh"};
            string[] lastName = new string[] { "Lane", "Samuelson", "Hansen", "Parker", "Stacy", "O'Brien", "Garfield", "Jackson", "Banner", "Kent" };
            string[] conditions = new string[] { "Blind", "Fever", "Diabetes", "Physical injury", "Allergy", "Bad breath", "Amnesia", "Lost leg", "Heartache", "Earache" };
            Patient patient = new Patient()
            {

            };
            return patient;
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

    }
}

    namespace HospitalObjects
{
    public class Patient
        {
            public int id;
            public string firstName;
            public string lastName;
            public int age;
            public string[] conditions;
            public string currentHospital;
        }

        public class Business
        {
            public string hospitalName = "Sacred Heart";
            public string adress = "12629 Riverside Drive";
            public string city = "North Hollywood";
            public int employees = 50;
        }
    }

