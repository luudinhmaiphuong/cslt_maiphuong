
namespace cslt_maiphuong
{
    internal class session_07
    {
        //public static int MaxOfThreeNumbers(int a, int b, int c)
        //{
        //    //return Math.Max(a, Math.Max(b, c));
        //    int max = 0;
        //    if (a > b && a > c)
        //        max = a;
        //    else if ((b > c && b > a)) max = b;
        //    else max = c;
        //    return max;    
        //}
        //static void Main(string[] args)
        //{
        //    int m = MaxOfThreeNumbers(5, 2, 4);
        //    Comsole.Writeline(m);
        //    Console.ReadKey();
        //}
        public static bool isPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= number; i++)
                if (number % i == 0) return false;
            return true;
        }
        static void PrintPrimeNumberUnderN(int n)
        {
            for (int i=2;i<=n;i++)
                if (isPrime(i))
                    Console.WriteLine(i);
        }
        static void printFirstNprime (int n)
        {
            int so = 2;
            int dem = 0;
            while (dem < n)
            {
                if (isPrime(so))
                {
                    Console.Write(so + ",");
                    dem++;
                }
                so++;
            }
        }
    }
}
