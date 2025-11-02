// "SAU" - Tạo một lớp
public class NguoiHienMau
{
    public string Ten { get; set; }

    // (4) Thay thế int bằng LỚP mới
    public LoaiMau LoaiMau { get; set; }
}
public class LoaiMau
{
    public string Ten { get; private set; }

    // (1) Dùng các thể hiện static để định nghĩa các loại
    public static readonly LoaiMau A = new LoaiMau("A");
    public static readonly LoaiMau B = new LoaiMau("B");
    public static readonly LoaiMau AB = new LoaiMau("AB");
    public static readonly LoaiMau O = new LoaiMau("O");

    // (2) Hàm dựng (constructor) là private để ngăn người khác tạo loại mới
    private LoaiMau(string ten)
    {
        Ten = ten;
    }

    // (3) ĐÓNG GÓI LOGIC vào chính lớp này
    public bool CoTheHienCho(LoaiMau nguoiNhan)
    {
        // Logic "O" (là this == O)
        if (this == LoaiMau.O)
        {
            return true;
        }

        // Logic "AB" (là this == AB)
        if (this == LoaiMau.AB)
        {
            return nguoiNhan == LoaiMau.AB;
        }

        // Logic "A" (là this == A)
        if (this == LoaiMau.A)
        {
            return (nguoiNhan == LoaiMau.A || nguoiNhan == LoaiMau.AB);
        }

        // Logic "B" (là this == B)
        if (this == LoaiMau.B)
        {
            return (nguoiNhan == LoaiMau.B || nguoiNhan == LoaiMau.AB);
        }

        return false;
    }

    public override string ToString() => Ten;
}

public class Program 
{
    static void Main(string[] args)
    {
        // VẤN ĐỀ 1 (Đã giải quyết): Code DỄ ĐỌC.
        var nguoiA = new NguoiHienMau { Ten = "An", LoaiMau = LoaiMau.A };
        var nguoiB = new NguoiHienMau { Ten = "Bình", LoaiMau = LoaiMau.O };

        // VẤN ĐỀ 2 (Đã giải quyết): AN TOÀN VỀ KIỂU.
        // var nguoiC = new NguoiHienMau { Ten = "Cường", LoaiMau = 99 }; // LỖI BIÊN DỊCH!
        // var nguoiD = new NguoiHienMau { Ten = "Dũng", LoaiMau = new LoaiMau("Z") }; // LỖI BIÊN DỊCH!
        // (Vì constructor là private)

        // VẤN ĐỀ 3 (Đã giải quyết): LOGIC GỌN GÀNG.
        // Không cần lớp Service bên ngoài nữa, ta hỏi trực tiếp đối tượng:
        Console.WriteLine($"An co the hien mau cho Bình không? " +
                          $"{nguoiA.LoaiMau.CoTheHienCho(nguoiB.LoaiMau)}"); // False

        Console.WriteLine($"Bình co the hiến mau cho An không? " +
                          $"{nguoiB.LoaiMau.CoTheHienCho(nguoiA.LoaiMau)}"); // True
    }
}