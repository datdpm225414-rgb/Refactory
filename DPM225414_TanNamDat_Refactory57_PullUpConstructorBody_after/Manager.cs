using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory57_PullUpConstructorBody_after
{
    internal class Manager : Employee
    {
        public string Grade;
        public Manager(string name, string id, string grade) : base(name, id)
        {
            this.Grade = grade;
        }
        public void Details()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Grade: " + Grade);
        }
    }
}
