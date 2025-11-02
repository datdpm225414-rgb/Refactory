using System.Diagnostics;

public class Program
{
    public static bool IsSpecialDeal()
    {
        Random random = new Random();
        int t = random.Next(1,10);
        if(t<6)
            return true;
        return false;
    }
    public static void Send()
    {
        Console.WriteLine("hello");
    }
    public static void Main(string[] args)
    {
        Random rand = new Random();
        double price = rand.Next(1, 100);
        double total = 0;
        if (IsSpecialDeal())
        {
            total = price * 0.95;
            Send();
        }
        else
        {
            total = price * 0.98;
            Send();
        }
    }
}