public class Program
{
    static double DisabilityAmount()
    {
        Random random = new Random();
        int seniority = random.Next(-5, 5);
        int monthsDisabled = random.Next(6, 20);
        bool isPartTime = true;
        if (seniority < 2)
        {
            return 0;
        }
        if (monthsDisabled > 12)
        {
            return 0;
        }
        if (isPartTime)
        {
            return 0;
        }
        // Compute the disability amount.
        // ...
        return 1;
    }
    public static void Main(string[] args)
    {
        if (DisabilityAmount() == 0)
            Console.WriteLine("0 hehe");
        else Console.WriteLine("ko phai 0");
    }
}