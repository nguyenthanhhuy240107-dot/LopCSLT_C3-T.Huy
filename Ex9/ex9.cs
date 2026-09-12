using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._09
{
    internal class ex9
    {
        static void Main(string[] args)
        {
            //- Nhập Điểm trung bình tích lũy (GPA: hệ 4.0) và Điểm rèn luyện (DRL: hệ 100).
            //- GPA >= 3.6 và DRL >= 90: Học bổng Xuất sắc (Mức 100%).
            //- GPA >= 3.2 và DRL >= 80: Học bổng Khá/Giỏi (Mức 50%).
            //- Không đủ 2 điều kiện trên: Không đạt học bổng.
            Console.Write("GPA: ");
            double gpa = double.Parse(Console.ReadLine());
            Console.Write("DRL: ");
            double drl = double.Parse(Console.ReadLine());
            if (gpa >= 3.2 && drl >= 80)
            {
                Console.WriteLine("Kết quả: Học bổng Khá/Giỏi (Mức 50%).");
            }
            else if (gpa >= 3.6 && drl >= 90)
            {
                Console.WriteLine("Kết quả: Học bổng Xuất sắc (Mức 100%).");
            }
            else
            {
                Console.WriteLine("Kết quả: Không đạt học bổng.");
            }
        }
    }
}
