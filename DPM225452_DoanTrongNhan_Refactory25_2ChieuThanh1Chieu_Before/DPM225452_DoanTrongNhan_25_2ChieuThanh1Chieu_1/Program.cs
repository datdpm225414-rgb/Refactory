public class KhachHang
{
    public string Ten { get; set; }

    // (1) Thêm tham chiếu ngược
    public List<DonHang> _donHangs = new List<DonHang>();

    public void Them(DonHang dh)
    {
        if (!_donHangs.Contains(dh)) // Kiểm tra tránh thêm trùng
        {
            _donHangs.Add(dh);
        }
    }

    public void Xoa(DonHang dh)
    {
        _donHangs.Remove(dh); // Xóa đơn hàng khỏi danh sách
    }
}

public class DonHang
{
    public int ID { get; set; }

    private KhachHang _khachHang;

    // (3) Thay thế public set bằng một hàm quản lý
    public KhachHang KhachHang => _khachHang;

    // (4) Hàm QUAN TRỌNG NHẤT: Quản lý cả hai liên kết
    public void GanVoiKhachHang(KhachHang khachHangMoi)
    {
        // Nếu _khachHang đã có rồi thì phải xóa DonHang khỏi KhachHang cũ
        if (_khachHang != null)
        {
            _khachHang.Xoa(this); // Xóa DonHang khỏi KhachHang cũ
        }

        // Gán KhachHang mới cho DonHang
        _khachHang = khachHangMoi;

        // Thêm DonHang vào danh sách DonHangs của KhachHang mới
        if (_khachHang != null)
        {
            _khachHang.Them(this);
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {
        KhachHang kh = new KhachHang { Ten = "A" };
        DonHang dh1 = new DonHang { ID = 1 };
        dh1.GanVoiKhachHang(kh); // Gán dh1 cho kh

        DonHang dh2 = new DonHang { ID = 2 };
        dh2.GanVoiKhachHang(kh); // Gán dh2 cho kh

        // In ra danh sách DonHang của KhachHang kh
        foreach (var dh in kh._donHangs)
        {
            Console.WriteLine($"DonHang ID: {dh.ID} cua khach {kh.Ten}");
        }
    }
}
