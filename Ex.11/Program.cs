using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //- Nhập số kWh tiêu thụ trong tháng:
            //+ Từ 0 đến 50 kWh: 1,806 VNĐ/kWh.
            //+ Từ 51 đến 100 kWh: 1,866 VNĐ/kWh (cho các kWh vượt mức 50).
            //+ Từ 101 kWh trở đi: 2,167 VNĐ/kWh (cho các kWh vượt mức 100).
            Console.Write("Nhập số kWh tiêu thụ: ");
            if (double.TryParse(Console.ReadLine(), out double kWh))
            {
                double T = 0;
                if (kWh <= 50)
                {
                    T = kWh * 1806;
                    Console.WriteLine($"Tổng tiền điện: {T} VNĐ (Chi tiết:{kWh} * 1,806 = {T})");
                }
                else if (kWh <= 100)
                {
                    T = 50 * 1806 + (kWh - 50) * 1866;
                    Console.WriteLine($"Tổng tiền điện: {T} VNĐ (Chi tiết: 50 * 1,806 + {(kWh - 50)} * 1,866 = {50 * 1806} + {(kWh - 50) * 1866})");
                }
                else
                {
                    T = 50 * 1806 + 50 * 1866 + (kWh - 100) * 2167;
                    Console.WriteLine($"Tổng tiền điện: {T} VNĐ (Chi tiết: 50 * 1,806 + 50 * 1,866 + {(kWh - 100)} * 2,167 = {50 * 1806} + {50 * 1866} + {(kWh - 100) * 2167})");
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số hợp lệ cho số kWh.");
            }
        }
    }
}
