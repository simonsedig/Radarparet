using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtherHospitalObjects;

namespace Hospital2
{
    class Program
    {
        static void Main(string[] args)
        {
            // access business module
            Business business = new Business();

            // create patients to transfer with .dll
            Patient otherPatient0 = new Patient()
            {
                firstName = "Olly",
                lastName = "Sjukhus2",
                age = 34,
                conditions = new string[] { "Förkyld", "Trött" },
                currentHospital = "anotherOne"
            };

            Patient otherPatient1 = new Patient()
            {
                firstName = "Trentycoul",
                lastName = "Sjukhus2",
                age = 37,
                conditions = new string[] { "Benbrott", "Blåmärke" },
                currentHospital = "anotherOne"
            };

            Patient otherPatient2 = new Patient()
            {
                firstName = "Menikozavic",
                lastName = "Sjukhus2",
                age = 52,
                conditions = new string[] { "Arbetsskadad", "Psykiska problem" },
                currentHospital = "anotherOne"
            };

        }
    }
}
namespace OtherHospitalObjects
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
        public string hospitalName = "Not very Sacred Heart";
        public string adress = "9642 Wajred Drive";
        public string city = "Dakota Woodpier";
        public int employees = 300;
    }
}