namespace ex3lab1
{
    internal class Program
    {
         public class Temperatura
        {
           public int C;
            public int F;
           public  Temperatura(int C, int F)
            {
                this.C = C;
                this.F = F;
            }
            public int dincinf(int C)
            {
               return F = C * 9 / 5 + 32; 
            }
            public int dinfinc(int F)
            {
              return C = (F - 32) * 5 / 9;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti temperatura in C");
            int C=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti temperatura in F");
            int F=Convert.ToInt32(Console.ReadLine());
            Temperatura temp = new Temperatura(C,F);
            Console.WriteLine("Conversia din C in F " + temp.dincinf(C));
            Console.WriteLine("conversia din F in C " + temp.dinfinc(F));
        }
    }
}
