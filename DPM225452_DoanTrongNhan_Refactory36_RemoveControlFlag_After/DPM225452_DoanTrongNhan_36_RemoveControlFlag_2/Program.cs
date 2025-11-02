public class Program

{
    public static void Main(string[] args)
    {
        Random random = new Random();

        int t = random.Next(0, 1); 
        switch (t)
        {
            case 0:
                Console.WriteLine("t = " + t);
                break;
            case 1:
                Console.WriteLine("t = " + t);
                break;
        }    
    }

}