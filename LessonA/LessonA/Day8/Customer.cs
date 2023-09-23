using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day8
{
    [Serializable]
    class Customer
    {
        private readonly double Id;
        public string Title = string.Empty;
        public String FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public double CreditLimit { get; set; }
        public Customer(double v1) 
        {
            Id = v1;
        }
        public double GetID() 
        {
            return Id;
        }
        public override string ToString()
        {
            return $"Details : {Id} {FirstName} {MiddleName} {LastName} {CreditLimit}";
        }

    }

}
