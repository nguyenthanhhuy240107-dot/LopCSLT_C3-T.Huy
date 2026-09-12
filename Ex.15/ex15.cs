using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._15
{
    internal class ex15
    {
        static void Main(string[] args)
        {
            //-Nhập Tháng(1 - 12) và Năm. Xuất số ngày của tháng đó.
            //-Tháng 1, 3, 5, 7, 8, 10, 12: 31 ngày.
            //- Tháng 4, 6, 9, 11: 30 ngày.
            //- Tháng 2: Nếu năm nhuận có 29 ngày, năm không nhuận có 28 ngày.
            //- (Năm nhuận là năm chia hết cho 400 hoặc[chia hết cho 4 và không chia hết cho 100])
            Console.Write("Tháng: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Năm: ");
            int Y = int.Parse(Console.ReadLine());
            int d;
            switch (M)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    d = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    d = 30;
                    break;
                case 2:
                    if ((Y % 400 == 0) || (Y % 4 == 0 && Y % 100 != 0))
                    {
                        d = 29;
                        Console.WriteLine("Tháng {0} năm {1} có {2} ngày (năm nhuận).", M, Y, d);
                    }
                    else
                    {
                        d = 28;
                        Console.WriteLine("Tháng {0} năm {1} có {2} ngày (năm không nhuận).", M, Y, d); 
                    }
                    break;
    
            }
        }
    }
}
