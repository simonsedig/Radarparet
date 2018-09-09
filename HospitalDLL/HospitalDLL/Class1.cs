using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDLL
{
    public class Class1
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
            public string hospitalName = "Sacred Heart";
            public string adress = "12629 Riverside Drive";
            public string city = "North Hollywood";
            public int employees = 50;
        }
    }
}
