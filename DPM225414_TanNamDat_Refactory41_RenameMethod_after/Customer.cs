using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory41_RenameMethod_after
{
    internal class Customer
    {
        private string firstname;
        private string secondname;
        public Customer(string firstname, string secondname)
        {
            this.firstname = firstname;
            this.secondname = secondname;
        }
        public string getFirstName()
        {
            return firstname;
        }
        public string getSecondName()
        {
            return secondname;
        }
    }
}
