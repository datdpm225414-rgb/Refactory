public class Program
{
    static double DisabilityAmount()
    {
        if(!IsNotEligibleForDisability())
            return 0;
        return 1;
    }

    static bool IsNotEligibleForDisability()
    {
        Random random = new Random();
        int seniority = random.Next(-5, 5);
        int monthsDisabled = random.Next(6, 20);
        bool isPartTime = true;
        if (seniority < 2)
        {
            return false;
        }
        if (monthsDisabled > 12)
        {
            return false;
        }
        if (isPartTime)
        {
            return false;
        }
        // Compute the disability amount.
        // ...
        return true;
    }
    public static void Main(string[] args)
    {
        if (DisabilityAmount() == 0)
            Console.WriteLine("0 hehe");
        else Console.WriteLine("ko phai 0");
    }
}