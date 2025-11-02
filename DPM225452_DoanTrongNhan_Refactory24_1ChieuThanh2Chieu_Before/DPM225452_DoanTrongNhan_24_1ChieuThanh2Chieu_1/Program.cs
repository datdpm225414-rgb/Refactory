// "TRƯỚC" - Một chiều (DonHang --> KhachHang)

public class KhachHang
{
    public string Ten { get; set; }
    // ... không biết gì về DonHang
}

public class DonHang
{
    public int ID { get; set; }
    public KhachHang KhachHang { get; set; } // <-- Chỉ 1 chiều này
}

public class Program
{
    static void Main(string[] args)
    {
        // VẤN ĐỀ KHI SỬ DỤNG:
        var khachA = new KhachHang { Ten = "Nguyen Van A" };
        var dh1 = new DonHang { ID = 101, KhachHang = khachA };
        var dh2 = new DonHang { ID = 102, KhachHang = khachA };
        var dh3 = new DonHang { ID = 103, KhachHang = khachA };

        // 1. Chiều xuôi (DonHang -> KhachHang) thì rất DỄ:
        Console.WriteLine($"Don hang {dh1.ID} là cua: {dh1.KhachHang.Ten}");

        // 2. Chiều ngược (KhachHang -> DonHang) thì KHÔNG THỂ:
        // HỎI: "Khách A có bao nhiêu đơn hàng?"
        // TRẢ LỜI: Không thể! 
        // Chúng ta phải duyệt TOÀN BỘ danh sách đơn hàng trong hệ thống 
        // và kiểm tra xem `dh.KhachHang == khachA`. Rất bất tiện và chậm!
    }
}
