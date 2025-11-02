// "TRƯỚC" - Lộ liễu
public class HocSinh
{
    public string Ten { get; set; }
    public int Tuoi { get; set; }
}

public class LopHoc
{
    public string TenLop { get; set; }

    // RẤT NGUY HIỂM: Bất kỳ ai cũng có thể get/set danh sách này
    public List<HocSinh> DanhSachHocSinh { get; set; }

    public LopHoc(string tenLop)
    {
        TenLop = tenLop;
        DanhSachHocSinh = new List<HocSinh>();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var lop10A = new LopHoc("10A");
        var hsAn = new HocSinh { Ten = "An", Tuoi = 15 };
        lop10A.DanhSachHocSinh.Add(hsAn); // Tạm ổn...

        // VẤN ĐỀ 1: Code bên ngoài tự do XÓA SẠCH danh sách
        lop10A.DanhSachHocSinh.Clear();
        // Lớp 10A bỗng dưng mất hết học sinh mà nó không hề hay biết!

        // VẤN ĐỀ 2: Code bên ngoài GÁN TRỰC TIẾP bằng null
        //lop10A.DanhSachHocSinh = null;
        // Dòng code tiếp theo gọi lop10A.DanhSachHocSinh.Count sẽ bị crash (NullReferenceException)

        // VẤN ĐỀ 3: Không thể VALIDATE dữ liệu đầu vào
        var hsGia = new HocSinh { Ten = "Ông Già", Tuoi = 99 };
        lop10A.DanhSachHocSinh.Add(hsGia); // Lớp học không thể ngăn chặn việc này
        
        var danhSachTenHocSinh = string.Join(", ", lop10A.DanhSachHocSinh.Select(hs => hs.Ten));
        Console.WriteLine(lop10A.TenLop +" co "+ danhSachTenHocSinh);// còn ông già
    }
}