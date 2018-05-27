using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n=0;
            do
            {
                Console.WriteLine("1.Jeśli chcesz samemu wybrać liczbę naciśnij 1");
                Console.WriteLine("2.Jeśli wolisz losową naciśnij 2");
                int switchCase;
                switchCase = int.Parse(Console.ReadLine());
                switch (switchCase)
                {
                    case (1):
                        Console.WriteLine("Wybierz liczbę nie większą niz 100 000");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine(n);
                        break;
                    case (2):
                        n = random.Next(20);
                        break;
                    default:
                        Console.WriteLine("Wcisnąłeś nie ten przycisk");
                        break;
                }
                Console.WriteLine("Wybrana liczba to {0} ",n);
            } while (n >= 100000);
            FirstNumber firstNumber = new FirstNumber(n);
            firstNumber.ItIsFirstNumber();


            Console.WriteLine("Kolejny program");
            for(int j = 0;j<10;j++)
                {
                    Console.WriteLine("######################################");
                }
            Console.WriteLine();
            do
            {
                n = random.Next(10);
            } while (n<0);
            Console.WriteLine("Wylosowana liczba do obliczenia silni to: " + n);

            int[] number=new int[n];
            long[] strong = new long[n];
            for(int i=0;i<n;i++)
            {
                number[i]= random.Next(1,5);
                strong[i] = 1;
                Console.WriteLine(i + " liczba w tablicy to " + number[i]);
            }
            for(int i = 0;i<n;i++)
            {
                for (int j = 1; j <= number[i]; j++)
                {strong[i] *= j;}
                Console.WriteLine("Silnia z liczby "+i+" w tablicy to "+strong[i]/10%10+ " " + strong[i]%10);
            }
            //Console.WriteLine("Strong of this number: "+strong);
            Console.WriteLine("Kolejny program");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("######################################");
            }
            int calculations = random.Next(10);
            PowerOfMath power = new PowerOfMath(calculations);
            for (int i = 0; i < calculations; i++)
            {
                double score = power.Exponentiation(random.Next(30), random.Next(5));
                Console.WriteLine("Potęga wynosi " +score+ " ostatnia cyfra "+score%10);
            }
            Console.ReadKey();
        }
    }
    public class FirstNumber
    {

        Random random = new Random();
        private int n;
        public FirstNumber(int n)
        {
            this.n = n;
        }
        public void ItIsFirstNumber()
        {

            int[] itIsFirstNumber = new int[n];

            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("Wczytaj liczbę");
                //itIsFirstNumber[i] = int.Parse(Console.ReadLine());
                itIsFirstNumber[i] = random.Next(10000);
            }

            Console.WriteLine("Kolejna pętla");
            for (int increment = 0; increment < n; increment++)
            {
                int pom = 0;
                Console.WriteLine("Liczba nr" + increment);
                for (int i = 1; i <= itIsFirstNumber[increment]; i++)
                {
                    if (itIsFirstNumber[increment] % i == 0)
                        pom = pom + 1;
                }
                Console.WriteLine(itIsFirstNumber[increment]);
                if (pom > 2)
                    Console.WriteLine("NIE");
                else
                {
                    if (itIsFirstNumber[increment] == 1)
                        Console.WriteLine("NIE");
                    else
                        Console.WriteLine("TAK");
                }
            }

        }
    }
    public class PowerOfMath
    {
        Random random = new Random();
        private int calculations;
        public PowerOfMath(int calculations)
        {
            this.calculations = calculations;
        }
        public double Exponentiation(double baseNumber,double exponentNumber )
        {
           return (Math.Pow(baseNumber,exponentNumber));
        }
    }
    /*
    public class ShortWord
    {
        private int C;
        public ShortWord(int C)
        {
            this.C = C;
        }
        public void CutWord()
        {
            string[] Word = new String[C];
            for(int i=0;i<C;i++)
            {
                Word[i] = Console.ReadLine();
            }
            for(int i =0;i<C;i++)
            {
                string[] foo = Word[i].Split
            }
        }

    }
    */
}
