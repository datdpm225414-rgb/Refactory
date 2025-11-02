// "SAU" - Bước 1: Tạo Interface
public interface ITrangThaiDonHang
{
    void DuyetDon(DonDatHang context);
    void HuyDon(DonDatHang context);
}

// "SAU" - Bước 2: Tạo các lớp Trạng thái
public class TrangThaiMoiTao : ITrangThaiDonHang
{
    public void DuyetDon(DonDatHang context)
    {
        Console.WriteLine("OK: Duyệt đơn.");
        // (A) Chuyển trạng thái của context sang Đã Duyệt
        context.ChuyenTrangThai(new TrangThaiDaDuyet());
    }

    public void HuyDon(DonDatHang context)
    {
        Console.WriteLine("OK: Hủy đơn.");
        // (B) Chuyển trạng thái của context sang Đã Hủy
        context.ChuyenTrangThai(new TrangThaiDaHuy());
    }
}

public class TrangThaiDaDuyet : ITrangThaiDonHang
{
    public void DuyetDon(DonDatHang context)
    {
        Console.WriteLine("LỖI: Đơn đã được duyệt rồi.");
    }

    public void HuyDon(DonDatHang context)
    {
        Console.WriteLine("LỖI: Đơn đã duyệt, không thể hủy.");
    }
}

public class TrangThaiDaHuy : ITrangThaiDonHang
{
    public void DuyetDon(DonDatHang context)
    {
        Console.WriteLine("LỖI: Đơn đã hủy, không thể duyệt.");
    }

    public void HuyDon(DonDatHang context)
    {
        Console.WriteLine("LỖI: Đơn đã được hủy rồi.");
    }
}
// "SAU" - Bước 3: Cập nhật lớp Context
public class DonDatHang
{
    public int ID { get; set; }
    private ITrangThaiDonHang _trangThaiHienTai; // <-- Thay thế enum bằng interface

    public DonDatHang()
    {
        // (C) Thiết lập trạng thái ban đầu
        _trangThaiHienTai = new TrangThaiMoiTao();
    }

    // (D) Hàm nội bộ để các State có thể thay đổi trạng thái
    public void ChuyenTrangThai(ITrangThaiDonHang trangThaiMoi)
    {
        _trangThaiHienTai = trangThaiMoi;
    }

    // (E) Các hàm public chỉ cần ỦY QUYỀN
    public void DuyetDon()
    {
        _trangThaiHienTai.DuyetDon(this);
    }

    public void HuyDon()
    {
        _trangThaiHienTai.HuyDon(this);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        var donHang = new DonDatHang();

        // Lần 1: Trạng thái là "MoiTao"
        donHang.DuyetDon(); // In ra: "OK: Duyệt đơn."
                            // (Bên trong, trạng thái đã tự động chuyển thành "DaDuyet")

        // Lần 2: Trạng thái bây giờ là "DaDuyet"
        donHang.DuyetDon(); // In ra: "LỖI: Đơn đã được duyệt rồi."
        donHang.HuyDon();   // In ra: "LỖI: Đơn đã duyệt, không thể hủy."
    }
}