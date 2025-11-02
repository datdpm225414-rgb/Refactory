using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory62_Extract_Interface_before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("Name: " + emp.GetName());
            Console.WriteLine("Department: " + emp.GetDepartment());
            Console.WriteLine("Rate: " + emp.GetRate());
            Console.WriteLine("Has Special Skill: " + emp.HasSpecialSkill());
            Console.ReadLine();
        }
    }
}
