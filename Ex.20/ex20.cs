using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._20
{
    internal class ex20
    {
        static void Main(string[] args)
        {
            //- Nhập Nhóm máu người nhận ("O", "A", "B", "AB").
            //- Xuất ra danh sách các nhóm máu mà người này có thể NHẬN được:
            //+ "O": Chỉ nhận được từ nhóm O. 
            //+ "A": Nhận được từ nhóm A, O. 
            //+ "B": Nhận được từ nhóm B, O. 
            //+ "AB": Nhận được từ tất cả các nhóm A, B, AB, O.
            Console.Write("Nhóm máu người nhận: ");
            string t = Console.ReadLine();
            switch (t)
            {
                case "O":
                    Console.WriteLine("Người có nhóm máu O có thể nhận từ nhóm máu: O");
                    break;
                case "A":
                    Console.WriteLine("Người có nhóm máu A có thể nhận từ nhóm máu: A, O");
                    break;
                case "B":
                    Console.WriteLine("Người có nhóm máu B  có thể nhận từ nhóm máu: B, O");
                    break;
                case "AB":
                    Console.WriteLine("Người có nhóm máu AB có thể nhận từ nhóm máu: A, B, AB, O");
                    break;
            }
    }
}
