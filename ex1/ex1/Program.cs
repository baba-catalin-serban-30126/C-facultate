namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" numărul de termeni  ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Primii {0} termeni ai secvenței Fibonacci sunt:", n);
            PrintFibonacciSequence(n);

        }
        static void PrintFibonacciSequence(int n)
        {
            int a = 0, b = 1, c;
            if (n >= 1)
                Console.Write(a + " ");
            if (n >= 2)
                Console.Write(b + " ");
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
