using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task1
{
    public class Task1
    {
        private int num;
        private int denom;

        public Task1(int a, int b)
        {
            int temp_a = a; // Нахождение НОК
            int temp_b = b;
            while (temp_b != 0)
            {
                int temp = temp_b;
                temp_b = temp_a % temp_b;
                temp_a = temp;
            }
            int gcd = temp_a;

            num = a / gcd;
            denom = b / gcd;

            if (denom == 0)
                throw new ArgumentException("Divide by zero(((");

            else if (denom < 0)
            {
                num = -num;
                denom = -denom;
            }

        }

        public override string ToString()
        {
            return $"{num}/{denom}";
        }

        public static Task1 operator + (Task1 a, Task1 b)
        {
            int result_num = (a.num * b.denom) + (b.num * a.denom);
            int result_denom = (a.denom * b.denom);
            Task1 result = new Task1(result_num, result_denom);
            return result;
        }

        public static Task1 operator - (Task1 a, Task1 b)
        {
            int result_num = (a.num * b.denom) - (b.num * a.denom);
            int result_denom = (a.denom * b.denom);
            Task1 result = new Task1(result_num, result_denom);
            return result;
        }

        public static bool operator == (Task1 a, Task1 b)
        {
            if ((a.num * b.denom) == (b.num * a.denom))
                    return true;
            else
                return false;
        }

        public static bool operator != (Task1 a, Task1 b)
        {
            if ((a.num * b.denom) == (b.num * a.denom))
                return false;
            else
                return true;
        }

        public static bool operator > (Task1 a, Task1 b)
        {
            if ((a.num * b.denom) > (b.num * a.denom))
                return true;
            else
                return false;
        }

        public static bool operator < (Task1 a, Task1 b)
        {
            if ((a.num * b.denom) < (b.num * a.denom))
                return true;
            else
                return false;
        }
    }
}
