// "SAU" - Đã được đóng gói an toàn
public class HocSinh
{
    public string Ten { get; set; }
    public int Tuoi { get; set; }
}
public class LopHoc
{
    public string TenLop { get; set; }

    // (1) Giữ danh sách thật ở chế độ PRIVATE
    private readonly List<HocSinh> _danhSachHocSinh = new List<HocSinh>();

    // (2) Cung cấp phiên bản "CHỈ ĐỌC" cho bên ngoài
    public IReadOnlyCollection<HocSinh> DanhSachHocSinh => _danhSachHocSinh.AsReadOnly();

    public LopHoc(string tenLop)
    {
        TenLop = tenLop;
    }

    // (3) Cung cấp các phương thức "quản lý" có kiểm soát
    public void ThemHocSinh(HocSinh hocSinhMoi)
    {
        // Ta có thể VALIDATE ở đây
        if (hocSinhMoi.Tuoi > 18)
        {
            Console.WriteLine($"Loi: {hocSinhMoi.Ten} quá tuoi vào lớp 10.");
            return;
        }

        if (_danhSachHocSinh.Count >= 40)
        {
            Console.WriteLine("Lỗi: Lớp đã đủ sĩ số.");
            return;
        }

        _danhSachHocSinh.Add(hocSinhMoi);
        Console.WriteLine($"Đã thêm {hocSinhMoi.Ten} vào lớp.");
    }

    public void XoaHocSinh(HocSinh hocSinh)
    {
        _danhSachHocSinh.Remove(hocSinh);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var lop10A = new LopHoc("10A");
        var hsAn = new HocSinh { Ten = "An", Tuoi = 15 };

        // CHỈ CÓ THỂ dùng phương thức được cung cấp
        lop10A.ThemHocSinh(hsAn); // In ra: "Đã thêm An vào lớp."

        // VẤN ĐỀ 1 (Đã giải quyết): Không thể xóa sạch
        // lop10A.DanhSachHocSinh.Clear(); // LỖI BIÊN DỊCH! 
        // 'IReadOnlyCollection' không có phương thức 'Clear()'.

        // VẤN ĐỀ 2 (Đã giải quyết): Không thể gán bằng null
        // lop10A.DanhSachHocSinh = null; // LỖI BIÊN DỊCH! 
        // Property này là "get-only" (chỉ đọc).

        // VẤN ĐỀ 3 (Đã giải quyết): Dữ liệu được validate
        var hsGia = new HocSinh { Ten = "Ong Gia", Tuoi = 99 };
        lop10A.ThemHocSinh(hsGia); // In ra: "Lỗi: Ông Già quá tuổi vào lớp 10."

        // Vẫn có thể XEM danh sách một cách an toàn
        Console.WriteLine($"Si so lop: {lop10A.DanhSachHocSinh.Count}"); // In ra: 1
    }
}