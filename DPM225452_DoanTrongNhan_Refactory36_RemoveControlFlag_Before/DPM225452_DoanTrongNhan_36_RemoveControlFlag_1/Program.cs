public class Program
{
    public static void Main(string[] args) 
    {
        bool flag = false;
        Random random = new Random();
        int t = random.Next(1,10);
        if (t > 5)
            flag = true;
        if (flag)
            Console.WriteLine("t>5, t = " + t);
        else Console.WriteLine("t<5, t = " + t);
    }
}