using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._10
{
    internal class ex10
    {
        static void Main(string[] args)
        {
            //- Nhập số tiền VNĐ và mã ngoại tệ ("USD", "EUR", "JPY").
            //- USD: Tỷ giá 25,400 VNĐ/USD.
            //- EUR: Tỷ giá 27,200 VNĐ/EUR.
            //- JPY: Tỷ giá 165 VNĐ/JPY.
            Console.Write("Số tiền VNĐ: ");
            double vnd = double.Parse(Console.ReadLine());
            Console.Write("Mã ngoại tệ (USD, EUR, JPY): ");
            string n = Console.ReadLine().ToUpper();
            switch (n)
            {
                case "USD":
                    double g =vnd/ 25400;
                    Console.Write($"Số tiền quy đổi: {g} USD");
                    break;
                case "EUR":
                    double e = vnd / 27200;
                    Console.Write($"Số tiền quy đổi: {e} EUR");
                    break;
                case "JPY":
                    double j = vnd / 165;
                    Console.Write($"Số tiền quy đổi: {j} JPY");
                    break;
                default:
                    Console.WriteLine("Mã ngoại tệ không hợp lệ.");
                    break;
            }

        }
    }
}
