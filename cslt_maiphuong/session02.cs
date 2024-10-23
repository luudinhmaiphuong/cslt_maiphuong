 internal class Session_02
 {
    public static void Main1()
        {
            //Question_01();
            //Question_02();
            Question_03();
        }
        public static void Question_01()
        {
            Console.Write("nhap Celsius: ");
            float c = float.Parse(Console.ReadLine());
            double k = c + 273;
            double f = c * 18 / 10 + 32;
            Console.WriteLine($"Kelvin: {k}");
            Console.WriteLine($"Fah: {f}");
        }
        public static void Question_02()
        {
            Console.Write("nhap canh: ");
            float a = float.Parse(Console.ReadLine());
            double pi = Math.PI;
            double s = 4 * pi * a;
            double v = 4 / 3 * pi * a;
            Console.WriteLine($"surface: {s}");
            Console.WriteLine($"volume: {v}");
        }
        public static void Question_03()
        {
            Console.Write("nhap a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("nhap b: ");
            float b = float.Parse(Console.ReadLine());
            double c = a + b;
            double d = a - b;
            double e = a * b;
            double f = a / b;
            double g = a % b;
            Console.WriteLine($"{a} + {b} = {c}");
            Console.WriteLine($"{a} - {b}= {d}");
            Console.WriteLine($"{a} * {b}= {e}");
            Console.WriteLine($"{a} / {b}= {f}");
            Console.WriteLine($"{a} mod {b} = {g}");
        }
 }