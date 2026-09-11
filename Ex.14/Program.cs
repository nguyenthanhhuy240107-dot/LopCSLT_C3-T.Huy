using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập Tổng giá trị đơn hàng và Mã voucher ("WELCOME10", "SUPERDEAL", "FREESHIP").
            // - "WELCOME10": Giảm 10% trên tổng hóa đơn.
            // - "SUPERDEAL": Giảm 20% nhưng giảm tối đa 100,000 VNĐ.
            // - "FREESHIP": Trừ cố định 30,000 VNĐ.
            Console.Write("Đơn hàng (VNĐ): ");
            double o = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mã voucher: ");
            string v = Console.ReadLine();
            switch (v)
            {
                case "WELCOME10":
                    Console.WriteLine("Được giảm 10%: {0} VNĐ. Số tiền cần thanh toán: {1} VNĐ.", o * 0.1, o * 0.9);
                    break;
                case "SUPERDEAL":
                    if (o * 0.2 >= 100000)
                    {
                        Console.WriteLine("Được giảm 20%(tối đa 100,000 VNĐ): {0} VNĐ. Số tiền cần thanh toán: {1} VNĐ.", 100000, o - 100000);
                    }
                    else
                    {
                        Console.WriteLine("Được giảm 20%(tối đa 100,000 VNĐ): {0} VNĐ. Số tiền cần thanh toán: {1} VNĐ.", o * 0.2, o * 0.8);
                    }
                    break;
                case "FREESHIP":
                    Console.WriteLine("Được giảm 30,000 VNĐ. Số tiền cần thanh toán: {0} VNĐ.", o - 30000);
                    break;
                default:
                    Console.WriteLine("Voucher không hợp lệ. Số tiền cần thanh toán: {0} VNĐ.", o);
                    break;
            }
        }
    }
}

