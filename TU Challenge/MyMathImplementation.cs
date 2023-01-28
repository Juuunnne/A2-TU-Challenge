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

        public static bool IsMajeur(int age) {

            if (age < 0 || age >= 150)
                throw new ArgumentException("Age must be between 0 and 150");

            return age >= 18 ? true : false; }

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
            for (int i = 2; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    numbers.Add(i);
               
                }
            }
            return numbers;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static int Power(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }
        
        public static int IsInOrder(int a, int b)
        {
            return a <= b ? (a < b ? 1 : 0) : -1;
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (IsInOrder(list[i], list[i + 1]) < 0)
                    return false;
            }
            return true;
        }

        public static List<int> Sort(List<int> toSort)
        {
            while (!IsListInOrder(toSort))
            {
                for (int i = 0; i < toSort.Count - 1; i++)
                {
                    if (IsInOrder(toSort[i], toSort[i + 1]) < 0)
                    {
                        int temp = toSort[i];
                        toSort[i] = toSort[i + 1];
                        toSort[i + 1] = temp;
                    }
                }
            }
            return toSort;
        }
        
        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            while (!IsListInOrder(toSort))
            {
                for (int i = 0; i < toSort.Count - 1; i++)
                {
                    if (isInOrder(toSort[i], toSort[i + 1]) < 0)
                    {
                        int temp = toSort[i];
                        toSort[i] = toSort[i + 1];
                        toSort[i + 1] = temp;
                    }
                }
            }
            return toSort;
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            return arg1 >= arg2 ? (arg1 > arg2 ? 1 : 0) : -1;
        }
    }
}
