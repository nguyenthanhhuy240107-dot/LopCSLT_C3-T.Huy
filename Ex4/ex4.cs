using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._04
{
    internal class ex4
    {
        static void Main(string[] args)
        {
            //- Khách hàng bấm phím từ 0 đến 4: 
            //- 1: Gặp tổng đài viên tư vấn thẻ. 
            //- 2: Tra cứu số dư tài khoản. 
            //- 3: Báo khóa thẻ khẩn cấp. 
            //- 4: Tra cứu tỷ giá ngoại tệ. 
            //- 0: Quay lại menu chính.
            //- Phím khác: "Lựa chọn không hợp lệ. Vui lòng thử lại!"

            Console.Write("Bấm phím (0-4): ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("[Tổng đài]:Gặp tổng đài viên tư vấn thẻ.");
                    break;
                case "2":
                    Console.WriteLine("[Tổng đài]:Tra cứu số dư tài khoản.");
                    break;
                case "3":
                    Console.WriteLine("[Tổng đài]:Báo khóa thẻ khẩn cấp.");
                    break;
                case "4":
                    Console.WriteLine("[Tổng đài]:Tra cứu tỷ giá ngoại tệ.");
                    break;
                case "0":
                    Console.WriteLine("[Tổng đài]:Quay lại menu chính.");
                    break;
                default:
                    Console.WriteLine("[Tổng đài]:Lựa chọn không hợp lệ. Vui lòng thử lại!");
                    break;
            }
        }
    }
}
