using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TanNamDat_Refactory09_SubstituteAlgorithm_after
{
    internal class SubstituteAlgorithm
    {
        string FoundPerson(string[] people)
        {
            List<string> candidates = new List<string>() { "Don", "John", "Kent" };

            for (int i = 0; i < people.Length; i++)
            {
                if (candidates.Contains(people[i]))
                {
                    return people[i];
                }
            }

            return String.Empty;
        }
        public static void Main()
        {
            int n;
            Console.WriteLine("Nhập vào độ dài mảng: ");
            n = Convert.ToInt32(Console.ReadLine());

            string[] people = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập vào đối tượng thứ " + (i + 1) + ": ");
                people[i] = Console.ReadLine();
            }

            SubstituteAlgorithm sb = new SubstituteAlgorithm();
            string result = sb.FoundPerson(people);

            if (!string.IsNullOrEmpty(result))
            {
                Console.WriteLine("Kết quả: Đã tìm thấy " + result);
            }
            else
            {
                Console.WriteLine("Không tìm thấy Don, John hoặc Kent.");
            }
        }

    }
}
