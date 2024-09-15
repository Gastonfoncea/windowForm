using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbEmpleados.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string leg { get; set; }
        public string section { get; set; }
        public string ofice { get; set; }

        public Employee() { }

        public Employee(int id, string name, string lastName, string leg, string section, string ofice)
        {
            Id = id;
            this.name = name;
            this.lastName = lastName;
            this.leg = leg;
            this.section = section;
            this.ofice = ofice;
        }
    }
}
