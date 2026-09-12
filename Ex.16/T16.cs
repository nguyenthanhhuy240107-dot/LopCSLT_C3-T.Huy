using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._16
{
    internal class T16
    {
        static void Main(string[] args)
        {
            //- Nhập Mã khu vực ("NOI_THANH", "NGOAI_THANH") và Trọng lượng gói hàng (kg).
            //- "NOI_THANH": Trọng lượng <= 3kg là 20,000 VNĐ. Mỗi kg tiếp theo thêm 5,000 VNĐ/kg.
            //- "NGOAI_THANH": Trọng lượng <= 3kg là 35,000 VNĐ. Mỗi kg tiếp theo thêm 10,000 VNĐ/kg.
            Console.Write("Khu vực: ");
            string k = Console.ReadLine().ToUpper();
            Console.Write("Trọng lượng (kg): ");
            float kg = float.Parse(Console.ReadLine());
            switch (k)
            {
                case "NOI_THANH":
                    if (kg <= 3)
                    {
                        Console.WriteLine("Phí vận chuyển: 20,000 VNĐ");
                    }
                    else
                    {
                        float F = 20000 + (kg - 3) * 5000;
                        Console.WriteLine($"Phí vận chuyển: {F} VNĐ");
                    }
                    break;
                case "NGOAI_THANH":
                    if (kg <= 3)
                    {
                        Console.WriteLine("Phí vận chuyển: 30,000 VNĐ");
                    }
                    else
                    {
                        float F = 30000 + (kg - 3) * 7000;
                        Console.WriteLine($"Phí vận chuyển: {F} VNĐ");
                    }
                    break;
                default:
                    Console.WriteLine("Mã khu vực không hợp lệ.");
                    break;
                
            }
        }
    }
}

