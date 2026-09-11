using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập Mức lương cơ bản và Tỷ lệ hoàn thành KPI(%).
            // KPI < 80 %: Không thưởng(0 %).
            // 80 % <= KPI < 100 %: Thưởng 50 % tháng lương.
            // 100 % <= KPI <= 120 %: Thưởng 100 % tháng lương.
            // KPI > 120 %: Thưởng 150 % tháng lương.
            Console.Write("Lương: ");
            double L = Convert.ToDouble(Console.ReadLine());
            Console.Write("KPI(%): ");
            double kpi = Convert.ToDouble(Console.ReadLine());
            if (kpi > 120)
            {
                Console.WriteLine("Đánh giá: Tối.Tiền thưởng Tết: {0} VNĐ ", L * 1.5);
            }
            else if (kpi >= 100)
            {
                Console.WriteLine("Đánh giá: Tối.Tiền thưởng Tết: {0} VNĐ ", L);
            }
            else if (kpi >= 80)
            {
                Console.WriteLine("Đánh giá: Tối.Tiền thưởng Tết: {0} VNĐ ", L * 0.5);
            }
            else
            {
                Console.WriteLine("Đánh giá: Tiền thưởng Tết: 0 VNĐ ");
            }
        }
    }
}
