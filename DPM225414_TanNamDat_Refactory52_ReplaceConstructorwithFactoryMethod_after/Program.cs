using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory52_ReplaceConstructorwithFactoryMethod_after
{
    internal class Program
    {
        static void Main()
        {
            string type;
            int Continue = 0;

            while (Continue != 1)
            {
                Console.WriteLine("Enter Employee Type (1 for Software Engineer, 2 for Hardware Engineer): ");
                type = Console.ReadLine();
                Employee emp = Employee.Create(type);

                emp.ShowEmployeeType();
                Console.WriteLine("Do you want to continue? (1 for No, 0 for Yes): ");
                Continue = Convert.ToInt32(Console.ReadLine());
            }


            Console.ReadLine();

        }
    }
}
