using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationApp.Impl {
    public class Employee: Person {
     
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal Salary { get; set; }
      

        public Employee():base() {

        }
        public Employee(string name, string surname, DateTime? dateStart, DateTime? dateEnd, decimal salary):base() {

            Name = name;
            Surname = surname;
           // DateStart = dateStart;
           // DateEnd = dateEnd;
            Salary = salary;
        }
    }
}

