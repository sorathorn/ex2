using System;

namespace ex22
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] a = new int[100];
            Console.Write("Input number: ");

            int n = Convert.ToInt16(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.Write("Input" + i + ":");

                a[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            Console.Write("A's Sort : ");
            Console.Write("B's Sort : ");
            Console.Write("C's Sort : ");
            Console.Write("D's Sort : ");
            for (i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
