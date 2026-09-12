using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex._05
{
    internal class ex5
    {
        static void Main(string[] args)
        {
            //- Giá mở cửa (1 km đầu): 15,000 VNĐ.
            //- Từ km thứ 2 đến km thứ 10: 12,000 VNĐ / km.
            //- Từ km thứ 11 trở đi: 10,000 VNĐ / km.
            //- Nếu tổng quãng đường > 30 km, giảm 10% trên tổng hóa đơn.
            Console.Write("Số km: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double km))
            {
                double tien1 = 0;
                double tien2 = 0;
                if (km <= 1)
                {
                    tien1 = 15000;
                }
                else if (km <= 10)
                {
                    tien1 = 15000 + (km - 1) * 12000;
                }
                else
                {
                    tien1 = 15000 + 9 * 12000 + (km - 10) * 10000;
                }
                if (km > 30)
                {
                    tien2 = tien1 * 0.9; // giảm 10%
                }
                Console.WriteLine($"Tổng tiền trước giảm: {tien1} VNĐ");
                Console.WriteLine($"khuyến mãi (10%): -{tien1 * 0.1} VNĐ");
                Console.WriteLine($"Thành tiền: {tien2} VNĐ");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số hợp lệ cho số km.");
            }

        }
    }
}
