using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DAL.Models
{
    public class Employee
    {
        public int Number { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int departmentno { get; set; }
        public string gender { get; set; }
        public DateTime dateofbirth { get; set; }
        public DateTime dateofjoining { get; set; }
        public int reportingto { get; set; }
        public long phone { get; set; }
        public int salary { get; set; }
        public int commission { get; set; }
        public string jobtitle { get; set; }
    }
}

