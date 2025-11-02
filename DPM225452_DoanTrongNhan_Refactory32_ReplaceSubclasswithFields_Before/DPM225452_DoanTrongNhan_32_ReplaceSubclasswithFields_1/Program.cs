// "TRƯỚC" - Lạm dụng kế thừa (Over-engineering)

public abstract class Person
{
    public string Ten { get; set; }

    // Hành vi duy nhất khác biệt
    public abstract char LayMaGioiTinh();
    public abstract string LayDanhXung();
}

// Lớp con 1
public class Male : Person
{
    public override char LayMaGioiTinh()
    {
        return 'M'; // Khác biệt duy nhất là hằng số 'M'
    }
    public override string LayDanhXung()
    {
        return "Ông"; // Khác biệt duy nhất là hằng số "Ông"
    }
}

// Lớp con 2
public class Female : Person
{
    public override char LayMaGioiTinh()
    {
        return 'F'; // Khác biệt duy nhất là hằng số 'F'
    }
    public override string LayDanhXung()
    {
        return "Bà"; // Khác biệt duy nhất là hằng số "Bà"
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person a = new Male { Ten= "A" };
        Person b = new Female { Ten = "B" };
        Console.WriteLine("Sex: "+a.LayMaGioiTinh()+", name: "+ a.LayDanhXung());
        Console.WriteLine("Sex: "+b.LayMaGioiTinh()+", name: " + b.LayDanhXung());
    }
}