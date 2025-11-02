public class NguoiHienMau
{
    public string Ten { get; set; }

    // Type Code: 0=A, 1=B, 2=AB, 3=O
    public int LoaiMau { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        var nguoiA = new NguoiHienMau { Ten = "An", LoaiMau = 0 }; // 0 là gì?
        var nguoiB = new NguoiHienMau { Ten = "Bình", LoaiMau = 3 }; // 3 là gì?

        // VẤN ĐỀ 2: KHÔNG AN TOÀN VỀ KIỂU (Type Safety).
        // Compiler cho phép gán giá trị vô nghĩa
        var nguoiC = new NguoiHienMau { Ten = "Cường", LoaiMau = 99 }; // Lỗi logic!

        // VẤN ĐỀ 3: LOGIC BỊ PHÂN TÁN (Scattered Logic).
        // Logic "ai có thể hiến cho ai" nằm bên ngoài, thường trong một hàm "Manager"

        NguoiHienMau choMau = new NguoiHienMau();
        NguoiHienMau nhanMau = new NguoiHienMau();

        if (choMau.LoaiMau == 0)
            Console.WriteLine("Cho hết");
        if(choMau.LoaiMau == 0 && (nhanMau.LoaiMau==0 || nhanMau.LoaiMau==2))//A
            Console.WriteLine("Cho được");
        // đầy logic rối rắm khác
    }
}