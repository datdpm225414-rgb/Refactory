// "TRƯỚC" - Dùng kiểu nguyên thủy string
public class NguoiDung
{
    public string Ten = "";
    public string SoDienThoai = ""; // <-- Đây là "Data Value"
    public bool IsValidPhoneNumber(string sdt)
    {
        if (string.IsNullOrWhiteSpace(sdt)) return false;
        if (sdt.Length != 10) return false;
        if (!sdt.StartsWith("0")) return false;
        return true;
    }

}
public class Program
{
    static void Main(string[] args)
    { 
        var nguoiA = new NguoiDung { Ten = "An", SoDienThoai = "Day la so dien thoai sao?" };
        if(nguoiA.IsValidPhoneNumber(nguoiA.SoDienThoai))
            Console.WriteLine(nguoiA.Ten + "," + nguoiA.SoDienThoai);
        else
            Console.WriteLine("So dien thoai khong hop le");
    }
}