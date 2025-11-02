public enum GioiTinh
{
    Nam, Nu
}

public class Person
{
    public string Ten { get; set; }
    public GioiTinh GioiTinh { get; set; }

    public char LayMaGioiTinh()
    {
        switch (this.GioiTinh)
        {
            case GioiTinh.Nam:
                return 'M';
            case GioiTinh.Nu:
                return 'F';
            default:
                throw new InvalidOperationException();
        }
    }

    public string LayDanhXung()
    {
        switch (this.GioiTinh)
        {
            case GioiTinh.Nam:
                return "Ông";
            case GioiTinh.Nu:
                return "Bà";
            default:
                throw new InvalidOperationException();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // "SAU": Tạo đối tượng đơn giản
        var ongA = new Person { Ten = "An", GioiTinh = GioiTinh.Nam };
        var baB = new Person { Ten = "Bình", GioiTinh = GioiTinh.Nu };

        Console.WriteLine($"{ongA.LayDanhXung()} {ongA.Ten}"); // In ra: Ông An
        Console.WriteLine($"{baB.LayDanhXung()} {baB.Ten}"); // In ra: Bà Bình
    }
}