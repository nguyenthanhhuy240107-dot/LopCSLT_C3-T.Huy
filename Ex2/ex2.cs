using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._02
{
    internal class ex2
    {
        static void Main(string[] args)
        {
            //- "ADMIN": "Toàn quyền quản trị hệ thống."
            //- "MANAGER": "Quyền quản lý nhân sự và xem báo cáo."
            //- "EMPLOYEE": "Quyền tạo và chỉnh sửa hồ sơ cá nhân."
            //- "GUEST": "Chỉ có quyền xem thông tin công khai."
            //- Trường hợp khác: "Mã vai trò không hợp lệ!" 

            Console.WriteLine("Nhập mã vai trò (ADMIN, MANAGER, EMPLOYEE, GUEST): ");
            switch (Console.ReadLine().ToUpper())
            {
                case "ADMIN":
                    Console.WriteLine("Toàn quyền quản trị hệ thống.");
                    break;
                case "MANAGER":
                    Console.WriteLine("Quyền quản lý nhân sự và xem báo cáo.");
                    break;
                case "EMPLOYEE":
                    Console.WriteLine("Quyền tạo và chỉnh sửa hồ sơ cá nhân.");
                    break;
                case "GUEST":
                    Console.WriteLine("Chỉ có quyền xem thông tin công khai.");
                    break;
                default:
                    Console.WriteLine("Mã vai trò không hợp lệ!");
                    break;
            }

        }
    }
}
