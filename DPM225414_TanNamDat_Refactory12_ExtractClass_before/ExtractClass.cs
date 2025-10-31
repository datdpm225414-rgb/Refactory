using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory12_ExtractClass_before
{
    internal class ExtractClass
    {
        public class Person
        {
            private string name;
            private string officeAreaCode;
            private string officeNumber;
            public Person(string name, string officeAreaCode, string officeNumber)
            {
                this.name = name;
                this.officeAreaCode = officeAreaCode;
                this.officeNumber = officeNumber;
            }
            public string GetTelephoneNumber()
            {

                return officeNumber;
            }
        }
        public static void Main()
        {
            Person ps = new Person("Tran Nam Dat", "123", "0344589304");
            string numPhone = ps.GetTelephoneNumber();
            Console.WriteLine(numPhone);

        }
    }
}

