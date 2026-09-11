using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //- Nhập mã trạng thái đơn hàng (1: Pending, 2: Processing, 3: Shipped, 4: Delivered, 5: Cancelled).
            //- 1 -> "Chờ xác nhận thanh toán."
            //- 2 -> "Đang đóng gói và bàn giao đơn vị vận chuyển."
            //- 3 -> "Đơn hàng đang trên đường giao đến bạn."
            //- 4 -> "Đơn hàng đã hoàn thành. Cảm ơn bạn!"
            //- 5 -> "Đơn hàng đã hủy. Xuất phiếu hoàn tiền."
            Console.Write("Trạng thái (1-5): ");
            
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("[Trạng thái]:Chờ xác nhận thanh toán.");
                    break;
                case "2":
                    Console.WriteLine("[Trạng thái]:Đang đóng gói và bàn giao đơn vị vận chuyển.");
                    break;
                case "3":
                    Console.WriteLine("[Trạng thái]:Đơn hàng đang trên đường giao đến bạn.");
                    break;
                case "4":
                    Console.WriteLine("[Trạng thái]:Đơn hàng đã hoàn thành. Cảm ơn bạn!");
                    break;
                case "5":
                    Console.WriteLine("[Trạng thái]:Đơn hàng đã hủy. Xuất phiếu hoàn tiền.");
                    break;
                default:
                    Console.WriteLine("Mã trạng thái không hợp lệ!");
                    break;
                }

            }
    }
}
