using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._19
{
    internal class ex19
    {
        static void Main(string[] args)
        {
            //- Nhập hai số thực A, B và một toán tử ('+', '-', '*', '/').
            //- Thực hiện phép tính tương ứng.
            //- Nếu là phép chia '/' và B = 0: Xuất thông báo lỗi "Không thể chia cho 0!"
            Console.Write("Số thực A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Số thực B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Toán tử (+, -, *, /): ");
            char o = Convert.ToChar(Console.ReadLine());
            switch(o)
            {
                case '+':
                    Console.WriteLine("Kết quả: {0}", A + B);
                    break;
                case '-':
                    Console.WriteLine("Kết quả: {0}", A - B);
                    break;
                case '*':
                    Console.WriteLine("Kết quả: {0}", A * B);
                    break;
                case '/':
                    if (B == 0)
                    {
                        Console.WriteLine("Lỗi:Không thể thực hiện phép chia cho 0!");
                    }
                    else
                    {
                        Console.WriteLine("Kết quả: {0}", A / B);
                    }
                    break;
                }
            }
    }
}
