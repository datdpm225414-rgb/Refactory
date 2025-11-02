public class SoDienThoai
{
    public string Value {  get; set; }

    public SoDienThoai(string value) 
    {
        if (!isValid(value))
        {
            throw new ArgumentException("Định dạng không hợp lệ");
        }
        Value = value;
    }

    public bool isValid(string sdt)
    {
        if (string.IsNullOrWhiteSpace(sdt)) return false;
        if (sdt.Length != 10) return false;
        if (!sdt.StartsWith("0")) return false;
        // ...
        return true;
    }
}

public class NguoiDung
{
    public string ten {  get; set; }
    public SoDienThoai SoDienThoai { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        SoDienThoai sdt = new SoDienThoai("0123456789");

        NguoiDung nd = new NguoiDung { ten="A", SoDienThoai = sdt};
        Console.WriteLine(nd.ten + ", "+ nd.SoDienThoai.Value);
    }
}