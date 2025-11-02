// "TRƯỚC" - Mỗi đơn hàng là một BẢN SAO
public class DonHang
{
    public int ID { get; set; }
    public string TenKhachHang { get; set; } // <-- Sao chép giá trị
    public string DiaChiKhachHang { get; set; } // <-- Sao chép giá trị
    // ... các thông tin khác của đơn hàng
    public string ThongTin()
    {
        return ID.ToString() + ", " + TenKhachHang + ", " + DiaChiKhachHang;
    }
}

// Vấn đề:
public class Program
{
    static void Main(string[] args)
    {
        var dh1 = new DonHang
        {
            ID = 101,
            TenKhachHang = "Nguyen Van A",
            DiaChiKhachHang = "123 Duong X"
        };
        var dh2 = new DonHang
        {
            ID = 102,
            TenKhachHang = "Nguyen Van A",
            DiaChiKhachHang = "123 Duong X"
        };

        Console.WriteLine(dh1.ThongTin());
        Console.WriteLine(dh2.ThongTin());
    }
}
