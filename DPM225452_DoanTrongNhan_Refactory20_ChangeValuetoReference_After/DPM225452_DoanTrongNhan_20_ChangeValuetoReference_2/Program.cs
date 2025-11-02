public class KhachHang
{
    public string Ten { get; set; }
    public string DiaChi { get; set; }

    public string ThongTin()
    {
        return Ten+ ", " +DiaChi;
    }
    // ...
}

// "SAU" - Các đơn hàng THAM CHIẾU đến 1 đối tượng duy nhất
public class DonHang
{
    public int ID { get; set; }
    public KhachHang KhachHang { get; set; } // <-- Thay thế bằng một tham chiếu!
    // ...
}

public class Program
{
    static void Main(string[] args)
    {
        var a = new KhachHang { Ten = "A", DiaChi = "123 Duong X" };

        var b = new DonHang { ID = 101, KhachHang = a };
        var c = new DonHang { ID = 102, KhachHang = a };

        Console.WriteLine(b.ID +", "+ b.KhachHang.ThongTin());
        Console.WriteLine(c.ID + ", " + b.KhachHang.ThongTin());
    }
}