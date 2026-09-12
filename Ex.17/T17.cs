using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._17
{
    internal class T17
    {
        static void Main(string[] args)
        {
            //- Nhập Nhiệt độ (°C) và Thời tiết (1: Nắng, 2: Mưa).
            //- Nhiệt độ < 18°C: "Mặc áo khoác dày, giữ ấm."
            //- Nhiệt độ 18 - 28°C: "Mặc áo phông/sơ mi thoải mái."
            //- Nhiệt độ > 28°C: "Mặc đồ thoáng mát, mang theo kem chống nắng."
            //- Nếu Thời tiết = 2 (Mưa): Bổ sung thêm câu: "Đừng quên mang theo ô/áo mưa!" 
            Console.Write("Nhiệt độ (°C): ");
            byte t = byte.Parse(Console.ReadLine());
            Console.Write("Thời tiết (1: Nắng, 2: Mưa): ");
            int W = int.Parse(Console.ReadLine());
            if (t > 28)
            {
                Console.WriteLine("Mặc đồ thoáng mát, mang theo kem chống nắng.");
            }
            else if (t >= 18)
            {
                Console.WriteLine("Mặc áo phông/sơ mi thoải mái.");
            }
            else
            {
                Console.WriteLine("Mặc áo khoác dày, giữ ấm.");
            }
            if (W == 2)
            {
                Console.WriteLine("Đừng quên mang theo ô/áo mưa!");
            }
            else if (W ==1)
            {
                
            }
            else 
            {
                Console.WriteLine("Mã thời tiết không hợp lệ.");
            }
        }
    }
}
