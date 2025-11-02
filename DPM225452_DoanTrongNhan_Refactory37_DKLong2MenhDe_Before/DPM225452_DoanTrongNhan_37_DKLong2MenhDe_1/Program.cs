//Thay thế Điều kiện lồng nhau bằng Mệnh đề bảo vệ
public class Test
{
    public bool isDead, isSeparated, isRetired = false;
    public double DeadAmount() { return 10; }
    public double SeparatedAmount() { return 8; }
    public double RetiredAmount() { return 7; }
    public double NormalPayAmount() { return 6; }
    public double GetPayAmount()
    {
        double result;

        if (isDead)
        {
            result = DeadAmount();//10
        }
        else
        {
            if (isSeparated)
            {
                result = SeparatedAmount();//8
            }
            else
            {
                if (isRetired)
                {
                    result = RetiredAmount();//7
                }
                else
                {
                    result = NormalPayAmount();//6
                }
            }
        }

        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Test test = new Test();
        Random random = new Random();
        int t = random.Next(0,2);
        switch(t)
        {
            case 0: test.isDead = true; break;
            case 1: test.isSeparated = true; break;
            case 2: test.isRetired = true; break;
        }
        Console.WriteLine("PayAmount = " + test.GetPayAmount());
    }
}