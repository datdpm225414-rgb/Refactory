public class Program
{
    public static bool isSummer(int date)
    {
        if (date > 5 && date < 10)
            return true;
        return false;
    }
    public static int SummerCharge(int q)
    {
        //winterRate = 4, winterServiceCharge=5
        return q * 4 +5;
    }
    public static int WinterCharge(int q)
    {
        //summerRate = 5
        return q * 5;
    }

    public static void Main(string[] args)
    {
        Random random = new Random();
        int date = random.Next(1,12);
        int quantity = random.Next(1,10);
        int charge = 0;
        if (isSummer(date))
        {
            charge = SummerCharge(quantity);
        }
        else
        {
            charge = WinterCharge(quantity);
        }
        Console.WriteLine("Charge = " + charge);
    }
}