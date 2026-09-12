using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bàitập
{
    internal class t1
    {
        public static void Main(string[] args)
        {
            Tx1(args);
            Tx2(args);
            Tx3(args);
        }
        static void Tx1(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        static void Tx2(string[] args)
        {
            int n = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{n} ");
                    n++;
                }
                Console.WriteLine();
            }
        }
        static void Tx3(string[] args)
        {
            int r = 4;   // số dòng (ở đây đủ để in từ 1 đến 10)
            int n = 1;    // bắt đầu từ số 1

            for (int i = 1; i <= r; i++)
            {
                // In khoảng trắng để căn giữa
                for (int s = 1; s <= r - i; s++)
                {
                    Console.Write(" ");
                }

                // In số liên tục
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{n} ");
                    n++;
                }
                Console.WriteLine();
            }

        }
    }
}
