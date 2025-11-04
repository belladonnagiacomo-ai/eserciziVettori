

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



            int[] array2 = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Dammi un numero");
                int numero = Convert.ToInt32(Console.ReadLine());

                array2[i] = numero;
            }

            for (int i = 0; i < N; i++)
            {
                if (array2[i] % 2 != 0)
                {
                    Console.WriteLine(array2[i]);
                }
            }






        }
    }
}