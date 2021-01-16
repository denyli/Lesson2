using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ученик - Андрей Марачковский
namespace Lesson2
{
    class Program
    {
        #region Task 01
        static void Task01()
        {
            Console.Write("Введите первое целое число: ");
            string strA = Console.ReadLine();
            Console.Write("Введите второе целое число: ");
            string strB = Console.ReadLine();
            Console.Write("Введите третье целое число: ");
            string strC = Console.ReadLine();

            int a = Convert.ToInt32(strA);
            int b = Convert.ToInt32(strB);
            int c = Convert.ToInt32(strC);

            if (a > b && a > c)
            {
                Console.WriteLine("Первое число самое большое");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Второе число самое большое");
            }
            else
            {
                Console.WriteLine("Третье число самое большое");
            }
            Console.ReadKey();
        }
        #endregion

        #region Task 02
        static void Task02()
        {
            int k = 0;
            Console.Write("Введите целое число: ");
            string strA = Console.ReadLine();
            foreach (char str in strA) {
                k++;                                                                  
            }
            Console.Write($"Количество символов во введенном числе: {k}");
            Console.ReadKey();
        }    
        #endregion

        #region Task 03
        static void Task03()
        {
            int sumNegative = 0;
            int sumPositive = 0;
            int a;
            do {
                Console.Write("Введите целое число: ");
                string strA = Console.ReadLine();

                a = Convert.ToInt32(strA);

                if (a % 2 == 0)
                {
                    sumPositive += a;
                }
                else
                {
                    sumNegative += a;
                }
            }
            while (a > 0);
            Console.WriteLine($"Сумма нечетных чисел: {sumNegative}");
            Console.WriteLine($"Сумма четных чисел: {sumPositive}");
            Console.ReadKey();
        }
        #endregion

        #region Task 04
        static void Task04()
        {
            string currentLogin = "root";
            string currentPassword = "GeekBrains";
            int k = 3;
            bool result = false;

            do
            {
                Console.Clear();
                Console.WriteLine($"Осталось попыток: {k}");
                Console.Write("Введите логин: ");
                string strLogin = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string strPassword = Console.ReadLine();

                if (strLogin == currentLogin && strPassword == currentPassword)
                {
                    result = true;
                    break;
                }
                k--;
            }
            while (k > 0);
            if (result)
                Console.WriteLine("Доступ разрешен!");
            else
                Console.WriteLine("Доступ запрешен!");
            Console.ReadKey();
        }
        #endregion

        static void Main(string[] args)
        {
            bool isExit = false;
            do
            {
                Console.Clear();
                Console.Write("Введите номер задания (1-4), либо число 0 для выхода: ");
                string strNumber = Console.ReadLine();

                int number = Convert.ToInt32(strNumber);

                switch (number)
                {
                    case 0:
                        isExit = true;
                        break;
                    case 1:
                        Console.Clear();
                        Task01();
                        break;
                    case 2:
                        Console.Clear();
                        Task02();
                        break;
                    case 3:
                        Console.Clear();
                        Task03();
                        break;
                    case 4:
                        Console.Clear();
                        Task04();
                        break;
                }
            }
            while (!isExit);
        }
    }
}
