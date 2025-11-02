using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main(string[] args)
    {
        int date = 10;
        int SUMMER_START = 6;
        int SUMMER_END = 9;
        int charge = 0;
        int summerRate = 5;
        int quantity= 4;
        int winterRate = 4;
        int winterServiceCharge = 5;

        if (date < SUMMER_START || date > SUMMER_END)
        {
            charge = quantity * winterRate + winterServiceCharge;
            
        }
        else
        {
            charge = quantity * summerRate;
        }
        Console.WriteLine("charge = "+charge);
    }
}