// Lớp logic nghiệp vụ
public class GioHang
{
    private List<decimal> _giaSanPham = new List<decimal>();
    public decimal TongTien { get; private set; }

    public void ThemSanPham(decimal gia)
    {
        _giaSanPham.Add(gia);
        // Tính toán lại tổng tiền
        this.TongTien = _giaSanPham.Sum();
    }
}

// Lớp giao diện (ví dụ: một Form hoặc một trang Web)
public class GiaoDienGioHang
{
    private GioHang _gioHang;
    private string _labelTongTienUI; // <-- Dữ liệu bị trùng lặp!

    public GiaoDienGioHang(GioHang gh)
    {
        _gioHang = gh;
        // Khởi tạo giá trị ban đầu cho UI
        _labelTongTienUI = $"Tổng: {_gioHang.TongTien} VND";
    }

    // Hành động khi người dùng nhấn nút "Thêm vào giỏ"
    public void OnButtonThemSanPham_Click(decimal giaMoi)
    {
        // 1. Cập nhật logic
        _gioHang.ThemSanPham(giaMoi);

        // 2. Cập nhật UI (thủ công)
        // VẤN ĐỀ: Nếu Lập trình viên QUÊN dòng này, UI sẽ hiển thị sai!
        //_labelTongTienUI = $"Tổng: {_gioHang.TongTien} VND";

        Console.WriteLine($"Đã thêm SP. UI hiển thị: {_labelTongTienUI}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var gh = new GioHang();
        decimal[] sp = {10,20,30,40};
        GiaoDienGioHang ui = new GiaoDienGioHang(gh);
        foreach (decimal gia in sp)
            ui.OnButtonThemSanPham_Click(gia);
    }
}