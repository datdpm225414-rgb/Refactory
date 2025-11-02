// "TRƯỚC" - Dùng class (kiểu tham chiếu) và CÓ THỂ BỊ THAY ĐỔI (mutable)
public class Money
{
    public decimal Amount { get; set; } // Có thể thay đổi từ bên ngoài
    public string Currency { get; set; }

    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }
}

public class SanPham
{
    public string Ten { get; set; }
    public Money Gia { get; set; }
    public void ApDungGiamGia(Money gia)
    {
        gia.Amount *= 0.8m; // <-- THAY ĐỔI trực tiếp đối tượng gốc
    }
}
public class Program
{
    static void Main(string[] args)
    {
        // VẤN ĐỀ 1: So sánh
        var priceA = new Money(50000, "VND");
        var priceB = new Money(50000, "VND");

        // Dù giá trị giống hệt nhau, nhưng chúng là 2 ĐỐI TƯỢNG khác nhau
        Console.WriteLine(priceA == priceB); // In ra: False (vì chúng là 2 tham chiếu khác nhau)

        // VẤN ĐỀ 2 (NGHIÊM TRỌNG): Giá trị bị thay đổi ngoài ý muốn
        var sanPhamA = new SanPham { Ten = "Áo Thun", Gia = priceA };
        var sanPhamB = new SanPham { Ten = "Quần Jean", Gia = priceA }; // Giả sử 2 SP này CÙNG tham chiếu đến 1 đối tượng giá


        sanPhamA.ApDungGiamGia(sanPhamA.Gia);

        //// Cả 2 sản phẩm đều bị giảm giá, dù bạn chỉ muốn giảm giá sản phẩm A
        Console.WriteLine(sanPhamA.Gia.Amount); // In ra 40000
        Console.WriteLine(sanPhamB.Gia.Amount); // Cũng in ra 40000 (LỖI LOGIC!)
    }
}
