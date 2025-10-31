using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory13_InlineClass_before
{
    internal class InlineClass
    {
        public class TelephoneNumber
        {
            private string officeAreaCode;
            private string Number;

            public TelephoneNumber(string officeAreaCode, string Number)
            {
                this.officeAreaCode = officeAreaCode;
                this.Number = Number;
            }
            public string GetTelephoneNumber()
            {
                return Number;
            }
        }
        public class Person
        {
            private string name;
            private TelephoneNumber telephoneNumber;
            public Person(string name, string officeAreaCode, string officeNumber)
            {
                this.name = name;
                this.telephoneNumber = new TelephoneNumber(officeAreaCode, officeNumber);
            }
            public string GetName()
            {
                return name;
            }

            public string GetTelephoneNumber()
            {
                return telephoneNumber.GetTelephoneNumber();
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
}
