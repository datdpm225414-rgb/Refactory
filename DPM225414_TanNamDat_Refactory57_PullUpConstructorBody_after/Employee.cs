using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory57_PullUpConstructorBody_after
{
    public class Employee
    {
        public string Name;
        public string ID;
        public Employee(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }

    }
}
