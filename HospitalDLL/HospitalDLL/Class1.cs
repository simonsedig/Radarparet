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
}
