using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void practice_1_for()
        {
            //讀入五個整數， 求這五個整數的和(for)

            Console.WriteLine("請輸入5個整數:");
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"第{i}個數值:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                sum = sum + tmp;
            }
            Console.WriteLine($"答案是{sum}");

            //int sum = 0;
            //Console.WriteLine("請輸入5個整數:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"第{i + 1}個數值:");
            //    int tmp = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + tmp;
            //}
            //Console.WriteLine($"答案是{sum}");


        }

        public static void practice_1_while()
        {
            //讀入五個整數， 求這五個整數的和(while) 

            Console.WriteLine("請輸入5個整數:");
            int sum = 0;
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine($"第{i}個數值:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                sum = sum + tmp;
                i++;
            }
            Console.WriteLine($"答案是{sum}");
        }


        public static void practice_2_for()
        {
            //求N個整數的和，N由使用者輸入(for)

            Console.WriteLine("請輸入N個整數:");
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                sum = sum + tmp;
                //or sum += tmp;
            }
            Console.WriteLine($"結果是{sum}");
        }

        public static void practice_2_while()
        {
            //求N個整數的和，N由使用者輸入(while)

            Console.WriteLine("請輸入N個整數:");
            int sum = 0;
            int i = 1;
            int N = Convert.ToInt32(Console.ReadLine());
            while (i <= N)
            {
                Console.WriteLine($"請輸入第{i}個數字:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                sum = sum + tmp;
                i = i + 1;
            }
            Console.WriteLine($"結果是{sum}");
        }

        public static void practice_3_for()
        {
            //假設有N個正整數，求其中的最大值


            Console.WriteLine("請輸入整數N:");
            int N = Convert.ToInt32(Console.ReadLine());
            int max = int.MinValue;    // 以確保在後續程式中,會被正確更新為更大的值
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp > max)
                {
                    max = tmp;
                }
            };
            Console.WriteLine($"最大數字是{max}");
        }

        public static void practice_3_while()
        {
            //假設有N個正整數，求其中的最大值

            Console.WriteLine("請輸入整數N:");
            int N = Convert.ToInt32(Console.ReadLine());
            int max = int.MinValue;
            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp > max)
                {
                    max = tmp;
                }
                i++;
            }
            Console.WriteLine($"最大數字是{max}");
        }

        public static void practice_4_for()
        {
            //假設有N個正整數，求最大奇數值(用%(取餘數)運算，例如將n除以2之後若餘0，為偶數，若餘1則為奇數)

            Console.WriteLine("請輸入整數N個正整數,求最大奇數值:");
            int N = Convert.ToInt32(Console.ReadLine());
            int max = int.MinValue;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp > max && (tmp % 2 == 1))
                {
                    max = tmp;
                }
            }
            if (max == int.MinValue)
            {
                Console.WriteLine("沒有奇數");
                return;
            }
            Console.WriteLine($"最大奇數為{max}");
        }

        public static void practice_4_while()
        {
            //假設有N個正整數，求最大奇數值(用%(取餘數)運算，例如將n除以2之後若餘0，為偶數，若餘1則為奇數)

            Console.WriteLine("請輸入整數N個正整數,求最大奇數值");
            int N = Convert.ToInt32(Console.ReadLine());
            int max = int.MinValue;
            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp > max && (tmp % 2 == 1))
                {
                    max = tmp;
                }
                i++;
            }
            if (max == int.MinValue)
            {
                Console.WriteLine("沒有奇數");
                return;
            }
            Console.WriteLine($"最大奇數為{max}");
        }

        public static void practice_5_for()
        {
            // 求N階層，即求1×2×3×…×N(請求輸入N，讓for迴圈自2依序乘到N，所以要寫成for (int i = 2; i < N + 1; i++))

            Console.WriteLine("請輸入N個階層:");
            int N = Convert.ToInt32(Console.ReadLine());
            int val = 1;
            for (int i = 2; i < N + 1; i++)
            {
                val = val * i;
            }
            Console.WriteLine($"{N}階層乘結果為{val}");
        }

        public static void practice_5_while()
        {
            // 求N階層，即求1×2×3×…×N(請求輸入N，讓for迴圈自2依序乘到N，所以要寫成for (int i = 2; i < N + 1; i++))

            Console.WriteLine("請輸入N個階層:");
            int N = Convert.ToInt32(Console.ReadLine());
            int val = 1;
            int i = 2;
            while (i < N + 1)
            {
                val = val * i;
                i++;
            }
            Console.WriteLine($"{N}階層乘結果為{val}");
        }

        public static void practice_6_for()
        {
            //輸出一個九九乘法表
            Console.WriteLine($"開始輸出99乘法表：");

            for (int i = 1; i < 10; i++)
            {
                //if (i == 5) { continue; }
                for (int j = 1; j < 10; j++)
                { Console.WriteLine($"{i}*{j}={i * j}"); }
            }
            Console.ReadKey();
        }

        public static void practice_6_while()
        {
            //輸出一個九九乘法表
            Console.WriteLine($"開始輸出99乘法表：");

            int i = 1;
            while (i < 10)
            {
                int j = 1;
                while (j < 10)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                    j++;
                }
                i++;
            }
            Console.ReadKey();

        }

        public static void practice_7_for()
        {
            //請將程式改成如下輸出：
            Console.WriteLine($"開始輸出99乘法表：");
            for (int i = 1; i < 10; i += 3)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}\t");
                    Console.Write($"{i + 1} * {j} = {(i + 1) * j}\t");
                    Console.WriteLine($"{i + 2} * {j} = {(i + 2) * j}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void practice_7_while()
        {
            //請將程式改成如下輸出：
            Console.WriteLine($"開始輸出99乘法表：");
            int i = 1;
            while (i < 10)
            {
                int j = 1;
                while (j < 10)
                {
                    Console.Write($"{i} * {j} = {i * j}\t");
                    Console.Write($"{i + 1} * {j} = {(i + 1) * j}\t");
                    Console.WriteLine($"{i + 2} * {j} = {(i + 2) * j}");
                    j++;
                }
                i += 3;
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void hw3_1_for()
        {
            //寫一程式，輸入10個整數，求其最小值

            Console.WriteLine("請輸入10個整數:");

            int min = int.MaxValue;
            int N = 10;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp < min)
                { min = tmp; }
            }
            Console.WriteLine($"最小數字是{min}");
        }

        public static void hw3_1_while()
        {
            //寫一程式，輸入10個整數，求其最小值

            Console.WriteLine("請輸入10個整數:");
            int min = int.MaxValue;
            int N = 10;
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"請輸入第{i + 1}個數:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp < min)
                { min = tmp; }
                i++;
            }
            Console.WriteLine($"最小數字是{min}");
        }

        public static void hw3_2_for()
        {
            // 寫一程式，輸入N個整數，求其最小值

            Console.WriteLine("請輸入整數N個:");
            int N = Convert.ToInt32(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp < min)
                {
                    min = tmp;
                }
            };
            Console.WriteLine($"最小數字是{min}");
        }

        public static void hw3_2_while()
        {
            // 寫一程式，輸入N個整數，求其最小值

            Console.WriteLine("請輸入整數N個:");
            int N = Convert.ToInt32(Console.ReadLine());
            int min = int.MaxValue;
            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp < min)
                {
                    min = tmp;
                }
                i++;
            }
            Console.WriteLine($"最小數字是{min}");
        }

        public static void hw3_3_for()
        {
            //寫一程式，輸入10個整數，列出其中所有大於12的數字

            Console.WriteLine("請輸入10個整數:");
            int[] number = new int[10];


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"大於12的數字:");
            for (int i = 0; i < 10; i++)
            {
                if (number[i] > 12)
                { Console.WriteLine(number[i]); }
            }
            Console.ReadKey();
        }

        public static void hw3_3_while()
        {
            //寫一程式，輸入10個整數，列出其中所有大於12的數字

            Console.WriteLine("請輸入10個整數:");
            int[] number = new int[10];
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                number[i] = int.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine($"大於12的數字:");
            foreach (int num in number)
            {
                if (num > 12)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public static void hw3_4_for()
        {
            //寫一程式，輸入10個整數，列出其中所有大於12的數字的總和
            Console.WriteLine("請輸入10個整數:");
            int[] number = new int[10];
            int sum = 0;
            string output = "";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp > 12)
                { sum += tmp; }
            }
            Console.WriteLine($"所有大於12的數字的總和為：{sum}");
        }

        public static void hw3_4_while()
        {
            //寫一程式，輸入10個整數，列出其中所有大於12的數字的總和
            Console.WriteLine("請輸入10個整數:");
            int[] number = new int[10];
            int sum = 0;
            string output = "";
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                i++;
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp > 12)
                { sum += tmp; }
            }
            Console.WriteLine($"所有大於12的數字的總和為：{sum}");
        }

        public static void hw3_5_for()
        {
            //寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15
            Console.WriteLine("請輸入N個數字:");
            int N = Convert.ToInt32(Console.ReadLine());
            int max = int.MinValue;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp > max && tmp % 2 != 0)
                { max = tmp; }
            }
            if (max % 2 == 0)
            { Console.WriteLine("沒有奇數"); }
            else
            { Console.WriteLine($"最大奇數為{max}"); }
        }

        public static void hw3_5_while()
        {
            //寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15
            Console.WriteLine("請輸入N個數字:");
            int N = Convert.ToInt32(Console.ReadLine());
            int max = int.MinValue;
            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp > max && tmp % 2 != 0)
                { max = tmp; }
                i++;
            }
            if (max % 2 == 0)
            { Console.WriteLine("沒有奇數"); }
            else
            { Console.WriteLine($"最大奇數為{max}"); }
        }

        public static void hw3_6_for()
        {
            //寫一程式，輸入N個數字，求其所有正數之平方的加總。例如輸入1,-2,3,-4,5五個數字，
            //得到(1)2 + (-2)2 + 32 + (-4)2 + 52 = 1 + 9 + 25 = 35
            Console.WriteLine("請輸入N個數字:");
            int N = Convert.ToInt32(Console.ReadLine());
            double output = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字");
                double tmp = Convert.ToDouble(Console.ReadLine());
                if (tmp > 0)
                { output = output + Math.Pow(tmp, 2); }
            }
            Console.WriteLine($"正整數的平方總和為:{output}");
        }

        public static void hw3_6_while()
        {
            //寫一程式，輸入N個數字，求其所有正數之平方的加總。例如輸入1,-2,3,-4,5五個數字，
            //得到(1)2 + (-2)2 + 32 + (-4)2 + 52 = 1 + 9 + 25 = 35
            Console.WriteLine("請輸入N個數字:");
            int N = Convert.ToInt32(Console.ReadLine());
            double output = 0;
            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字");
                double tmp = Convert.ToDouble(Console.ReadLine());
                if (tmp > 0)
                { output = output + Math.Pow(tmp, 2); }
                i++;
            }
            Console.WriteLine($"正整數的平方總和為:{output}");
        }

        public static void hw3_7_for()
        {
            //寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如-7會被轉換成7
            Console.WriteLine("請輸入N個數字:");
            int N = Convert.ToInt32(Console.ReadLine());
            string output = "";
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (output.Length != 0)
                { output = output + ","; }
                output = output + Convert.ToString(Math.Abs(tmp));
            }
            Console.WriteLine($"所有正整數為:{output}");
        }

        public static void hw3_7_while()
        {
            //寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如 - 7會被轉換成7
            Console.WriteLine("請輸入N個數字:");
            int N = Convert.ToInt32(Console.ReadLine());
            string output = "";
            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字");
                int tmp = Convert.ToInt32(Console.ReadLine());

                if (output.Length != 0)
                { output = output + ","; }
                output = output + Convert.ToString(Math.Abs(tmp));
                i++;
            }
            Console.WriteLine($"所有正整數為:{output}");
        }

        public static void add3_1_for()
        {
            //判斷101 - 200之間有多少個質數，並輸出所有質數
            int count = 0;

            for (int i = 101; i < 200; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine($"101~200之間共有{count}個質數");
        }

        public static void add3_1_while()
        {
            //判斷101 - 200之間有多少個質數，並輸出所有質數

            int count = 0;
            int i = 101;

            while (i < 200)
            {
                bool isPrime = true;
                int j = 2;
                while (j <= Math.Sqrt(i))
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    j++;
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                    count++;
                }
                i++;
            }
            Console.WriteLine($"101~200之間共有{count}個質數");
        }


        public static void add3_2_for()
        {
            // 輸入一個數，輸出其質因數
            Console.WriteLine("請輸入一個正整數:");
            int n = Convert.ToInt32(Console.ReadLine());
            string output = "";
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    { output += i + ""; }
                }
            }
            Console.WriteLine($"{n}的質因數有：{output}");
        }


        public static void add3_2_while()
        {
            // 輸入一個數，輸出其質因數
            Console.WriteLine("請輸入一個正整數:");
            int n = Convert.ToInt32(Console.ReadLine());
            string output = "";
            int i = 2;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    bool IsPrime = true;
                    int j = 2;
                    while (j <= Math.Sqrt(i))
                    {
                        if (i % j == 0)
                        {
                            IsPrime = false;
                            break;
                        }
                        j++;
                    }

                    if (IsPrime)
                    { output += i + ""; }
                }
                i++;
            }
            Console.WriteLine($"{n}的質因數有：{output}");
        }

        public static void add3_3_for()
        {
            //求100到300中可以被3與7整除的個數
            int count = 0;
            for (int i = 100; i <= 300; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                { count++; }
            }
            Console.WriteLine($"100到300中可以被3與7整除的個數為:{count}");
        }


        public static void add3_3_while()
        { //求100到300中可以被3與7整除的個數
            int count = 0;
            int i = 100;
            while (i <= 300)
            {
                if (i % 3 == 0 && i % 7 == 0)
                { count++; }
                i++;
            }
            Console.WriteLine($"100到300中可以被3與7整除的個數為:{count}");
        }

        public static void practice4_1()
        {
            //輸入兩數,求最大公約數(Greatest Common Divisor，簡寫G.C.D.，或稱最大公因數)

            Console.WriteLine("請輸入第一個正數:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入第二個正數:");
            int y = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int max = 1;
            while ((i < x) && (i <= y))
            {
                if ((x % i == 0) && (y % i == 0))
                { max = i; }

                i++;
            }
            Console.WriteLine($"最大公因數為: {max}");
        }

        public static void practice4_2()
        {
            //計算N個數字的和。檢查i有沒有超過N，超過就不做了。
            Console.WriteLine("請輸入N個整數:");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int i = 1;
            while (i <= N)
            {
                Console.WriteLine($"第{i}個數值:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                sum = sum + tmp;
                i++;

                if (i > N)
                { break; }
            }
            Console.WriteLine($"答案是{sum}");
        }


        public static void hw4_1()
        {
            //利用while寫一程式求N個數字的最大值
            Console.WriteLine("請輸入N個數字:");
            int N = Convert.ToInt32(Console.ReadLine());
            int max = int.MinValue;
            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                if (tmp >= max)
                {
                    max = tmp;
                }
                i++;
            }
            Console.WriteLine($"最大數字是{max}");
        }

        public static void hw4_2()
        {
            //利用while寫一程式求一個等差級數數字的和，一共有N個數字，程式應該輸入最小的起始值以及數字間的差。
            //(即從起始值開始，間格差，共N個 的總和)
            Console.WriteLine("請輸入N個整數:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入起始值:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入間隔差:");
            int interval = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (0 < N)
            {
                sum = sum + start;
                start = start + interval;
                N--;
            }
            Console.WriteLine($"等級差總和為:{sum}");
        }

        public static void hw4_3()
        {
            //利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和
            Console.WriteLine("請輸入N個整數:");
            int N = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x > 13)
                { sum = sum + x; }
                i++;
            }
            Console.WriteLine($"小於13的數字和為:{sum}");
        }

        public static void hw4_4()
        {
            //利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字
            Console.WriteLine("請輸入N個整數");
            int N = Convert.ToInt32(Console.ReadLine());
            string output = "";
            int i = 0;
            while (i < N)
            {
                Console.WriteLine($"請輸入第{i + 1}個數字:");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x > 7 && x < 10)
                {
                    Console.WriteLine($"第一個大於7且小於10的數字:{x}");
                    break;
                }
                i++;
            }
            Console.WriteLine();
        }

        public static void hw4_5()
        {
            //利用while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai > bi，即停止，並列印出ai及bi

            Console.WriteLine("找到第一個ai > bi，即停止，並列印出ai及bi:");

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine($"請輸入a{i + 1}");
                int ai = int.Parse(Console.ReadLine());

                Console.WriteLine($"請輸入b{i + 1}");
                int bi = int.Parse(Console.ReadLine());

                if (ai > bi)
                {
                    Console.WriteLine($"找到第一個ai > bi為:{ai}>{bi}");
                    break;
                }
                i++;
            }
            //        int i = 0;
            //        while (i < 5)
            //        {
            //            Console.Write("請輸入a{0}：", i + 1);
            //            int ai = int.Parse(Console.ReadLine());

            //            Console.Write("請輸入b{0}：", i + 1);
            //            int bi = int.Parse(Console.ReadLine());

            //            if (ai > bi)
            //            {
            //                Console.WriteLine("找到第一個 ai > bi：");
            //                Console.WriteLine("ai = {0}", ai);
            //                Console.WriteLine("bi = {0}", bi);
            //                break;
            //            }
            //            i++;
            //        }
            //        if (i == 5)
            //        {
            //            Console.WriteLine("未找到 ai > bi");
            //        }
        }


        public static void add4_1()
        {
            //Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。
            //假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。

            Console.WriteLine("請輸入一段時間(分鐘):");
            double time = Convert.ToDouble(Console.ReadLine());
            double count = 0;

            while (time >= 5)
            {
                count++;
                time -= 5;
            }
            Console.WriteLine($"在此分鐘內，吃了 {count} 個漢堡");
        }


        public static void add4_2()
        {
            //小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清

            double money = 560;
            int month = 0;
            while (money > 0)
            {
                money -= 4;
                month++;
                if (month % 12 == 0)
                { money--; }
            }
            Console.WriteLine($"需要{month}個月還清");
        }

        public static void add4_3()
        {
            //系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！，猜錯時，要提示是比較大還是比較小
            Random random = new Random();
            int pass = random.Next(0, 100), guess;
            Console.WriteLine("隨機產生數字(1~100),請輸入猜測數字:");
            while (true)
            {
                Console.WriteLine("請輸入猜測數字:");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == pass)
                {
                    Console.WriteLine("恭喜你猜對了!");
                    break;
                }
                else if (guess > pass)
                { Console.WriteLine($"比{guess}小一點"); }
                else { Console.WriteLine($"比{guess}大一點"); }
            }
            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            practice_1_for();
            practice_1_while();
            practice_2_for();
            practice_2_while();
            practice_3_for();
            practice_3_while();
            practice_4_for();
            practice_4_while();
            practice_5_for();
            practice_5_while();
            practice_6_for();
            practice_6_while();
            practice_7_for();
            practice_7_while();

            hw3_1_for();
            hw3_1_while();
            hw3_2_for();
            hw3_2_while();
            hw3_3_for();
            hw3_3_while();
            hw3_4_for();
            hw3_4_while();
            hw3_5_for();
            hw3_5_while();
            hw3_6_for();
            hw3_6_while();
            hw3_7_for();
            hw3_7_while();

            add3_1_for();
            add3_1_while();
            add3_2_for();
            add3_2_while();
            add3_3_for();
            add3_3_while();

            practice4_1();
            practice4_2();

            hw4_1();
            hw4_2();
            hw4_3();
            hw4_4();
            hw4_5();
            add4_1();
            add4_2();
            add4_3();

        }
    }
}
    






