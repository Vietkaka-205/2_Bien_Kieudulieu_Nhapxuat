namespace _2_Bien_Kieudulieu_Nhapxuat
{
    //Khái niệm
    /*
     * Biến là gì:Biến được tạo ra để lưu trữ các giá trị với 1 kiểu dữ liệu nào đó.
     * Kiểu dữ liệu cho phép chúng ta xác định loại dữ liệu mà biến đó sử dụng, có một số 
     * loại kiểu dữ liệu phổ biến như: int, long, short, floa, double, string...
     * Giới hạn của dữ liệu:
     * int int32 - 32 bit có miền giá trị từ -2^31 đến 2^31-1
     * long:int64 - 64 bit  có miền giá trị từ -2^63 đến 2^63
     * Nhập xuất dữ liệu:  trong ngôn ngữ lập trình C#, dữ liệu có thể được nhập vào từ bàn phím
     * của chương trình thông qua phương thức Console.ReadLine() phương thức này trả về 1 chuỗi (string)
     * Cú pháp để in dữ liệu ra màn hình là cốnle.WriteLine()
     */
    internal class Program
    {
        // Xác định đầu ra UTF8


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //Console.WriteLine("Hãy nhập tên người yêu cũ");
            //string tenNYC = Console.ReadLine();
            //Console.WriteLine(tenNYC);

            //Console.WriteLine("Hãy nhập tiếp xem sao");
            //int z = Console.Read();
            //Console.Write(Convert.ToChar(z));
            //Ép kiểu và nhập dữ liệu
            //Ép kiểu được sinh ra để chuyển đổi dữ liệu từ kiểu này sang kiểu khác để phù hợp với mục đích lập trình
            //Ép kiểu tường minh/trực tiếp là khi chúng ta sử dụng các hàm, phương thức để thực hiện ép kiểu

            // int x;// Khai báo biến x kiểu int
            //int y = 10; //Khởi tạo biến ý có giá trị là int 10
            //Console.WriteLine("Hãy nhập vào dữ liệu");
            //string duLieuNhap=Console.ReadLine();
            //x = int.Parse(duLieuNhap);//Nếu dữ liệu null-> lỗi
            //x = Convert.ToInt32(duLieuNhap);// Null-> 0
            //Console.WriteLine(x);

            //Nhập tên, tuổi, nhập cân nặng của bạn trai người yêu cũ
            Console.WriteLine("Ten ban trai nyc");
            string ten = Console.ReadLine();
            Console.WriteLine("Tuoi ban trai nyc");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Can nang ban trai nyc");
            double canNang = Convert.ToDouble(Console.ReadLine());

            //Cách 1 sử dụng dấu +
            Console.WriteLine("Tên: " + ten + " Tuổi: " + tuoi + " Cân: " + canNang);

            //Format code: ctrl K D, comment crtl K C, bỏ comment Ctrl K U
            //Dulicate code: Ctrl D, Xoá toàn bộ code Ctrl A Delete
            //Ép kiểu ngầm được chương trình tự động ép từ kiểu dữ liệu
            //có phạm vi biếu diễn nhỏ hơn sang kiểu dữ liệu có phạm vi biểu diễn lớn hơn
            //Cách 2 sử dụng các dấu {} và số
            Console.WriteLine("Tên:{0} Tuổi : {1} Nặng: {2}", ten, tuoi, canNang);
            //Cách 3 sử dụng $ để nhúng thẳng biến vào string
            Console.WriteLine($"Tên:{ten}, Tuổi:{tuoi}, Cân nặng:{canNang}");
        }
    }
}
