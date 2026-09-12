using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._03
{
    internal class ex3
    {
        static void Main(string[] args)
        {
            //- Nhập số dư tài khoản và số tiền muốn rút.
            //- Số tiền rút phải lớn hơn 0.
            //- Số tiền rút phải là bội số của 50,000 VNĐ.
            //- Số tiền rút không vượt quá số dư hiện tại. 
            //- Hạn mức rút tối đa 5,000,000 VNĐ / lần.
            //- Xuất ra lý do từ chối cụ thể nếu không đủ điều kiện, hoặc thông báo rút thành công.

            Console.Write("Nhập số dư tài khoản: ");
            double T = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập số tiền muốn rút: ");
            double C = Convert.ToDouble(Console.ReadLine());
            if (C <= 0)
            {
                Console.WriteLine("Số tiền rút phải lớn hơn 0.");
            }
            else if (C % 50000 != 0)
            {
                Console.WriteLine("Số tiền rút phải là bội số của 50,000 VNĐ.");
            }
            else if (C > T)
            {
                Console.WriteLine("Số tiền rút không được vượt quá số dư hiện tại.");
            }
            else if (C > 5000000)
            {
                Console.WriteLine("Số tiền rút không được vượt quá hạn mức 5,000,000 VNĐ / lần.");
            }
            else
            {
                Console.WriteLine("Rút tiền thành công, số dư còn lại: {0}", T - C);
            }   

        }
    }
}
