using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DPM225414_TanNamDat_Refactory57_PullUpConstructorBody_before
{
    public class Manager : Employee
    {
        private string Grade;

        public Manager(string name, int id, string grade) 
        {
            this.name = name;
            this.id = id;
            this.Grade = grade;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name}, ID: {id}, Grade: {Grade}");
        }
    }
}
