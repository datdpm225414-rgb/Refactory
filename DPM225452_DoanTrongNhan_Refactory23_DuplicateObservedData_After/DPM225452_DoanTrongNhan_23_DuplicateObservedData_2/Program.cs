// Lớp logic nghiệp vụ (nay là Chủ thể)
public class GioHang
{
    // C# 'event' là cách triển khai Observer Pattern đơn giản nhất
    public event Action<decimal> TongTienThayDoi; // (1) Khai báo sự kiện

    private List<decimal> _giaSanPham = new List<decimal>();

    private decimal _tongTien;
    public decimal TongTien
    {
        get => _tongTien;
        private set
        {
            _tongTien = value;
            // (2) Kích hoạt sự kiện cho bất kỳ ai đang lắng nghe
            TongTienThayDoi?.Invoke(_tongTien);
        }
    }

    public void ThemSanPham(decimal gia)
    {
        _giaSanPham.Add(gia);
        // Chỉ cần gán giá trị, sự kiện sẽ tự động được kích hoạt
        this.TongTien = _giaSanPham.Sum();
        //Khi TongTien được gán giá trị vd 10, set accessor được kích hoạt.
        //set accessor gọi: TongTienThayDoi?.Invoke(10). (Sự kiện được BẮN RA!)
    }
}

// Lớp giao diện (nay là Người quan sát)
public class GiaoDienGioHang
{
    private GioHang _gioHang;
    private string _labelTongTienUI=""; // Chỉ còn 1 nơi lưu trữ "nguồn chân lý"

    public GiaoDienGioHang(GioHang gh)
    {
        _gioHang = gh;
        // (3) Đăng ký lắng nghe sự kiện
        _gioHang.TongTienThayDoi += CapNhatGiaoDien; // "+=" là đăng ký

        // Khởi tạo giá trị
        CapNhatGiaoDien(_gioHang.TongTien);
    }

    // (4) Đây là hàm "Callback" sẽ tự động được gọi khi có sự kiện
    private void CapNhatGiaoDien(decimal tongTienMoi)
    {
        _labelTongTienUI = $"Tổng: {tongTienMoi} VND";
        Console.WriteLine($"Sự kiện kích hoạt! UI tự cập nhật: {_labelTongTienUI}");
    }

    public void OnButtonThemSanPham_Click(decimal giaMoi)
    {
        // Bây giờ chỉ cần gọi logic
        _gioHang.ThemSanPham(giaMoi);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        GioHang gioHang = new GioHang();
        decimal[] sp = { 10, 20, 30, 40 };
        GiaoDienGioHang ui = new GiaoDienGioHang(gioHang);
        foreach (decimal s in sp)
            ui.OnButtonThemSanPham_Click(s);
    } 
}