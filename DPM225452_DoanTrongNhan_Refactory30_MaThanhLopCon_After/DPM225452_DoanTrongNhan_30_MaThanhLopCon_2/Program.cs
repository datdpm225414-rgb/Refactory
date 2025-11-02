// "SAU" - Bước 2: Các lớp con cụ thể

// "SAU" - Bước 1: Lớp cha trừu tượng
public abstract class NhanVien
{
    public string Ten { get; set; }

    // (1) Định nghĩa hành vi chung, nhưng không triển khai
    public abstract decimal TinhLuong();
}
// Lớp con 1
public class NhanVienBienChe : NhanVien
{
    // (2) Chỉ chứa dữ liệu nó cần
    public decimal LuongThang { get; set; }

    // (3) Triển khai logic của riêng nó
    public override decimal TinhLuong()
    {
        return this.LuongThang;
    }
}

// Lớp con 2
public class NhanVienTheoGio : NhanVien
{
    // (2) Chỉ chứa dữ liệu nó cần
    public int SoGioLam { get; set; }
    public decimal DonGiaGio { get; set; }

    // (3) Triển khai logic của riêng nó
    public override decimal TinhLuong()
    {
        return this.SoGioLam * this.DonGiaGio;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        NhanVien nva = new NhanVienBienChe { Ten = "A", LuongThang = 2000 };
        NhanVien nvb = new NhanVienTheoGio { Ten = "B", SoGioLam = 10, DonGiaGio = 100 };
        Console.WriteLine("Nv: " + nva.Ten + ", luong = " + nva.TinhLuong()+" VND");
        Console.WriteLine("Nv: " + nvb.Ten + ", luong = " + nvb.TinhLuong() + " VND");
    }
}