using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_ExtractMethod
{
    public class ExtractMethod
    {
        public void Main()
        {
            PrintStudentInfo("Nam", 8.5);
        }

        public void PrintStudentInfo(string name, double score)
        {
            PrintHeader();
            PrintDetails(name, score);
        }

        public void PrintHeader()
        {
            Console.WriteLine("Thông tin học sinh");
        }

        public void PrintDetails(string name, double score)
        {
            Console.WriteLine("Tên: " + name);
            Console.WriteLine("Điểm trung bình: " + score);
        }
    }
}
