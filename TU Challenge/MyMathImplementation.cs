using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (var number in numbers)
            {
                total += number;
            }

            return total;
        }

        public static bool IsMajeur(int age) { return age > 18 ? true : false; }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsDivisible(int numberX, int numberY)
        {

            if (numberX % numberY == 0)
                return true;
            else return false;
        }

        public static bool IsPrimary(int a)
        {
            int j = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    j++;
                }
            }

            if (j == 2)
                return true;

            else return false;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> numbers = new List<int>();
            int count = 0;
            for (int i = 1; i < a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                    numbers.Add(i);

                else count = 0;
            }
            return numbers;
        }
    }
}
