using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Company(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Add(double percentage)
        {
            Salary +=  Salary * percentage/100;
        }


        public override string ToString()
        {
            return Id + " " + Name + " " + Salary;
        }
    }
}
