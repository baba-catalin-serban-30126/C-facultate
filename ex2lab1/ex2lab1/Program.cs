using System.Runtime.InteropServices;

namespace ex2lab1
{
    internal class Program
    {
        class Calcule()
        {
            public double a;
            public double b;


            public Calcule(double num1, double num2) : this()
            {
                this.a = num1;
                this.b = num2;
            }
            public double adunare()
            {

                return a + b;
            }
            public double scadere()
            {

                return a - b;
            }
            public double inmultire()
            {
                return a * b;
            }
            public double impartire()
            {
                return a / b;

            }
            public void afisare()
            {
                Console.WriteLine("Numar 1: " + a);
                Console.WriteLine("Numar 2: " + b);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul numar real: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduceti al doilea numar real: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Calcule cal1 = new Calcule(num1, num2);
            Console.WriteLine("Rezultatele operațiilor matematice:");
            Console.WriteLine("Adunare: " + cal1.adunare());
            Console.WriteLine("Scadere: " + cal1.scadere());
            Console.WriteLine("Inmultire: " + cal1.inmultire());
            Console.WriteLine("Impărtire: " + cal1.impartire());


        }


    }
}
    

