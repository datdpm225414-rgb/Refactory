// "TRƯỚC" - Dùng 1 lớp với mã loại
public enum LoaiNhanVien
{
    BienChe,
    TheoGio
}

public class NhanVien
{
    public LoaiNhanVien Loai { get; set; }
    public string Ten { get; set; }

    // Dữ liệu cho cả 2 loại bị TRỘN LẪN
    public decimal LuongThang { get; set; } // Dùng cho Biên chế
    public int SoGioLam { get; set; }      // Dùng cho Theo giờ
    public decimal DonGiaGio { get; set; } // Dùng cho Theo giờ

    // VẤN ĐỀ: Hàm này vi phạm Nguyên tắc Mở/Đóng (Open/Closed Principle)
    public decimal TinhLuong()
    {
        switch (this.Loai)
        {
            case LoaiNhanVien.BienChe:
                return this.LuongThang;

            case LoaiNhanVien.TheoGio:
                return this.SoGioLam * this.DonGiaGio;

            // Nếu thêm loại "Nhân viên thời vụ" (Commissioned)
            // BẠN PHẢI SỬA đổi code trong hàm này.
            // case LoaiNhanVien.ThoiVu:
            //     return ...

            default:
                throw new InvalidOperationException("Loại nhân viên không hợp lệ");
        }
    }
}