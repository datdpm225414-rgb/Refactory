// "SAU" - Dùng "record struct" (kiểu giá trị) và BẤT BIẾN
public class Money
{
    public decimal Amount { get; } // Chỉ có thể gán 1 lần lúc khởi tạo
    public string Currency { get; }

    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    // Nếu cần thay đổi, ta tạo ra một BẢN SAO MỚI
    public Money ApDungGiamGia(decimal percent)
    {
        var newAmount = this.Amount * (1 - percent);
        return new Money(newAmount, this.Currency); // Trả về đối tượng MỚI
    }
}

public class SanPham
{
    public string Ten { get; set; }
    public Money Gia  { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        // Vấn đề 1 được giải quyết: So sánh dựa trên giá trị
        var priceA = new Money(50000, "VND");
        var priceB = new Money(50000, "VND");

        Console.WriteLine(priceA == priceB); // In ra: True (tuyệt vời!)

        // Vấn đề 2 được giải quyết: Tính bất biến
        var sanPhamA = new SanPham { Ten = "Áo Thun", Gia = priceA };
        var sanPhamB = new SanPham { Ten = "Quần Jean", Gia = priceB }; // Giờ B là 1 bản sao

        // Hàm giảm giá không thể thay đổi giá trị gốc, nó phải gán lại
        // sanPhamA.Gia.Amount = 40000; // LỖI BIÊN DỊCH! Không thể gán.

        // Phải dùng hàm để tạo ra giá trị MỚI
        var giaMoiCuaA = sanPhamA.Gia.ApDungGiamGia(0.2m); // (0.2m = 20%)
        sanPhamA.Gia = giaMoiCuaA; // Gán lại giá trị mới cho A

        // Chỉ sản phẩm A thay đổi, sản phẩm B an toàn
        Console.WriteLine(sanPhamA.Gia.Amount); // In ra 40000
        Console.WriteLine(sanPhamB.Gia.Amount); // Vẫn là 50000 (ĐÚNG LOGIC!)
    }
}