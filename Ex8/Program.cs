using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //- Nhập loại xe ("BIKE" hoặc "CAR") và thời gian gửi (1: Ban ngày, 2: Ban đêm).
            //- "BIKE": Ban ngày = 5,000 VNĐ | Ban đêm = 10,000 VNĐ.
            //- "CAR": Ban ngày = 30,000 VNĐ | Ban đêm = 60,000 VNĐ.
            Console.Write("Loại xe (BIKE/CAR): ");
            string l = Console.ReadLine().ToUpper();
            Console.Write("Thời gian gửi (1: Ban ngày/2: Ban đêm): ");
            string t = Console.ReadLine();

            switch (l)
            {
                case "BIKE":
                    if (t == "1")
                    {
                        Console.WriteLine("Phí gửi Bike (Ban ngày): 5,000 VNĐ");
                    }
                    else if (t == "2")
                    {
                        Console.WriteLine("Phí gửi Bike (Ban đêm): 10,000 VNĐ");
                    }
                    else
                    {
                        Console.WriteLine("Thời gian gửi không hợp lệ.");
                    }
                    break;
                case "CAR":
                    if (t == "1")
                    {
                        Console.WriteLine("Phí gửi Car (Ban ngày): 30,000 VNĐ");
                    }
                    else if (t == "2")
                    {
                        Console.WriteLine("Phí gửi Car (Ban đêm): 60,000 VNĐ");
                    }
                    else
                    {
                        Console.WriteLine("Thời gian gửi không hợp lệ.");
                    }
                    break;
                default:
                    Console.WriteLine("Loại xe không hợp lệ.");
                    break;
                }

            }
    }
}
