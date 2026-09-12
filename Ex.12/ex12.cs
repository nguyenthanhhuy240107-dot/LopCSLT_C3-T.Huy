using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._12
{
    internal class ex12
    {
        static void Main(string[] args)
        {
            //- Nhập số ngày trễ hạn trả sách.
            //- Trễ 1 đến 3 ngày: Phạt 5,000 VNĐ/ngày.
            //- Trễ 4 đến 7 ngày: Phạt 10,000 VNĐ/ngày.
            //- Trễ trên 7 ngày: Phạt 20,000 VNĐ/ngày + Khóa thẻ thư viện 30 ngày.
            Console.Write("Số ngày trễ hạn = ");
            if (int.TryParse(Console.ReadLine(), out int day) && day >= 1 && day <= 3)
            {
                double F = day * 5000;
                Console.Write("Phạt: {0} VNĐ", F);
            }
            else if (day >= 4 && day <= 7)
            {
                double F = day * 10000;
                Console.Write("Phạt: {0} VNĐ", F);
            }
            else if (day > 7)
            {
                double F = day * 20000;
                Console.WriteLine("Phạt: {0} VNĐ ", F);
                Console.WriteLine("Cảnh báo: Khóa thẻ thư viện 30 ngày.");
            }
            else
            {
                Console.WriteLine("Số ngày trễ hạn không hợp lệ.");
            }
        }
    }
}
