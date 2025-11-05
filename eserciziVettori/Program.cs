

namespace eserciziArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int[] num = { 5, 8, 9, 25, -5 };
            num = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("dammi un numero");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int z = num.Length - 1; z >= 0; z--)
            {
                Console.WriteLine(num[z]);

            }
            Console.WriteLine("-----------------------------");
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("dammi un numero");
                int n = Convert.ToInt32(Console.ReadLine());
                array[i] = n;
            }
            for (int i = 0; i < N; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }

            Console.WriteLine("-----------------------------");

            int[] array2 = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Dammi un numero");
                int num2 = Convert.ToInt32(Console.ReadLine());

                array2[i] = num2;
            }

            for (int i = 0; i < N; i++)
            {
                if (array2[i] % 2 != 0)
                {
                    Console.WriteLine(array2[i]);
                }
            }
            Console.WriteLine("-----------------------------");
            int[] array3 = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Dammi un numero");
                int num3 = Convert.ToInt32(Console.ReadLine());

                array3[i] = num3;
            }
            int a = 0, p = 0;
            for (int i = 0;i < N; i++)
            {
                if (array3[i] % 2 != 0)
                {
                     a++;
                }
                else
                {
                    p++;
                }
            }
            Console.WriteLine("ci sono " + p + " numeri pari");
            Console.WriteLine("ci sono " + a + " numeri dispari");


        }
    }
}