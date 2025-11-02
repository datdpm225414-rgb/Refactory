using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory61_ExtractSuperclass_before
{
    internal class Employee
    {
        public string Name { get; set; }
        public double AnnualCost { get; set; }
        public string ID { get; set; }
        public Employee(string name, double annualCost, string id)
        {
            Name = name;
            AnnualCost = annualCost;
            ID = id;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetAnnualCost()
        {
            return AnnualCost;
        }
        public string GetID()
        {
            return ID;
        }


    }
}
