using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //- Nhập chiều cao (m) và cân nặng (kg).
            //Tính BMI = Cân nặng / (Chiều cao ^ 2).
            //- BMI < 18.5: "Thầy gầy - Nên bổ sung dinh dưỡng."
            //- 18.5 <= BMI < 25: "Cân đối - Tiếp tục duy trì."
            //- 25 <= BMI < 30: "Thừa cân - Nên tăng cường luyện tập."
            //- BMI >= 30: "Béo phì - Cần sự tư vấn từ bác sĩ."
            Console.Write("Chiều cao (m): ");
            float m = Convert.ToSingle(Console.ReadLine());

            Console.Write("Cân nặng (kg): ");
            float kg = Convert.ToSingle(Console.ReadLine());

            float bmi= kg / (m * m);
            bmi = (float)Math.Round(bmi, 2);
            if (bmi < 18.5)
            {
                Console.WriteLine("BMI: {0} - Đánh giá: Thầy gầy - Nên bổ sung dinh dưỡng.", bmi);
            }
            else if (bmi < 25)
            {
                Console.WriteLine("BMI: {0} - Đánh giá: Cân đối - Tiếp tục duy trì.", bmi);
            }
            else if (bmi < 30)
            {
                Console.WriteLine("BMI: {0} - Đánh giá: Thừa cân - Nên tăng cường luyện tập.", bmi);
            }
            else
            {
                Console.WriteLine("BMI: {0} - Đánh giá: Béo phì - Cần sự tư vấn từ bác sĩ.", bmi);
            }
        }
    }
}
