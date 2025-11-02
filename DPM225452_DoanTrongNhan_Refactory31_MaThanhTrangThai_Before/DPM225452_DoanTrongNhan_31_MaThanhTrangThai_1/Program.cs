// "TRƯỚC" - Dùng enum và switch
public enum TrangThaiDonHang
{
    MoiTao,
    DaDuyet,
    DaHuy
}

public class DonDatHang
{
    public int ID { get; set; }
    public TrangThaiDonHang TrangThai { get; private set; } // Mã loại

    public DonDatHang()
    {
        this.TrangThai = TrangThaiDonHang.MoiTao;
    }

    // VẤN ĐỀ: Hai hàm này chứa logic nghiệp vụ phức tạp
    public void DuyetDon()
    {
        switch (this.TrangThai)
        {
            case TrangThaiDonHang.MoiTao:
                Console.WriteLine("OK: Duyệt đơn.");
                this.TrangThai = TrangThaiDonHang.DaDuyet; // <-- Thay đổi trạng thái
                break;
            case TrangThaiDonHang.DaDuyet:
                Console.WriteLine("LỖI: Đơn đã được duyệt rồi.");
                break;
            case TrangThaiDonHang.DaHuy:
                Console.WriteLine("LỖI: Đơn đã hủy, không thể duyệt.");
                break;
        }
    }

    public void HuyDon()
    {
        switch (this.TrangThai)
        {
            case TrangThaiDonHang.MoiTao:
                Console.WriteLine("OK: Hủy đơn.");
                this.TrangThai = TrangThaiDonHang.DaHuy; // <-- Thay đổi trạng thái
                break;
            case TrangThaiDonHang.DaDuyet:
                Console.WriteLine("LỖI: Đơn đã duyệt, không thể hủy.");
                break;
            case TrangThaiDonHang.DaHuy:
                Console.WriteLine("LỖI: Đơn đã được hủy rồi.");
                break;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DonDatHang dh = new DonDatHang();
        dh.DuyetDon();
        dh.HuyDon();
    }
}