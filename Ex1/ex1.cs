using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._01
{
    internal class ex1
    {
        static void Main(string[] args)
        {
            //- Người > 60 tuổi hoặc < 12 tuổi: Giá vé là 50,000 VNĐ.
            //- Từ 12 đến 60 tuổi: Suất chiếu ban ngày (trước 17h) giá 80,000 VNĐ, suất chiếu buổi tối (từ 17h trở đi) giá 110,000 VNĐ.

            Console.Write("Nhập tuổi: ");
            Double age = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập giờ chiếu: ");
            Byte hour = Convert.ToByte(Console.ReadLine());

            if (age > 60 || age < 12)
            {
                Console.WriteLine("Giá vé là 50,000 VNĐ.");
            }
            else
            {
                if (hour < 17)
                {
                    Console.WriteLine("Giá vé là 80,000 VNĐ.");
                }
                else
                {
                    Console.WriteLine("Giá vé là 110,000 VNĐ.");
                }
            }


        }
    }
}
