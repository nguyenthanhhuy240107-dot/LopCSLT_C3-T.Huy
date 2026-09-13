using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._18
{
    internal class ex18
    {
        static void Main(string[] args)
        {
            //- Nhập Mật khẩu (chuỗi văn bản).
            //- Độ dài < 6 ký tự: "Mật khẩu Yếu: Quá ngắn (tối thiểu 6 ký tự)."
            //- Độ dài từ 6 - 11 ký tự: "Mật khẩu Trung bình: Nên kết hợp ký tự đặc biệt."
            //- Độ dài >= 12 ký tự: "Mật khẩu Mạnh." 
            Console.Write("Nhập mật khẩu: ");
            string mk = Console.ReadLine();
            int length = mk.Length;
            if (length >= 12)
            {
                Console.WriteLine("Đánh giá: Mật khẩu Mạnh.");
            }
            else if (length >= 6)
            {
                Console.WriteLine("Đánh giá: Mật khẩu Trung bình: Nên kết hợp ký tự đặc biệt.");
            }
            else
            {
                Console.WriteLine("Đánh giá: Mật khẩu Yếu: Quá ngắn (tối thiểu 6 ký tự).");
            }
        }
    }
}
