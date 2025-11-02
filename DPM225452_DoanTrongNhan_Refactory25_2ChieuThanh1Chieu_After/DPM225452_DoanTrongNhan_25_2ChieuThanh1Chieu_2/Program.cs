public class KhachHang
{
    public string Ten { get; set; }
}

public class DonHang
{
    public int ID { get; set; }
    public KhachHang khachHang { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        // Tạo và gán liên kết (giờ rất đơn giản)
        var khachA = new KhachHang { Ten = "Nguyen Van A" };
        var dh1 = new DonHang { ID = 101, khachHang = khachA };
        var dh2 = new DonHang { ID = 102, khachHang = khachA };

        // Giả lập một Repository
        var allDonHangs = new List<DonHang> { dh1, dh2 };

        // HỎI: "Khách A có bao nhiêu đơn hàng?"
        // TRẢ LỜI: Dùng Repository để truy vấn
        var donHangCuaKhachA = allDonHangs
            .Where(dh => dh.khachHang.Ten == khachA.Ten)
            .ToList();

        Console.WriteLine($"Khách {dh1.khachHang.Ten} có {donHangCuaKhachA.Count} đơn hàng."); // In ra: 2
    }
}
