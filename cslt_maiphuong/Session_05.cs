internal class Session_05
{
    public static void Main()
    {
        //Question_01();
        //Question_02();
        Question_03();
    }
    public static void Question_01()
    {
        Console.Write("nhap so: ");
        int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is even.");
            }
            else
            {
                Console.WriteLine($"{a} is odd.");
            }
       
    }
    public static void Question_02()
    {
        Console.Write("nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("nhap so c: ");
        int c = int.Parse(Console.ReadLine());
        int l = a;
        if (b > l)
        {
            l = b;
        }
        if (c > l)
        {
            l = c;
        }
        Console.WriteLine($"{l} lon nhat");
    }
    public static void Question_03()
    {
        Console.Write("nhap x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("nhap y: ");
        int y = int.Parse(Console.ReadLine());
        if (x == 0 && y == 0)
        {
            Console.WriteLine($"({x};{y}) khong thuoc quadrant nao");
        }
        else
        {
            if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine($"({x};{y}) in the 3th quadrant");
                }
                else
                {
                    Console.WriteLine($"({x};{y}) in the 2th quadrant");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine($"({x};{y}) in the 1th quadrant");
                }
                else
                {
                    Console.WriteLine($"({x};{y}) in the 4th quadrant");
                }
            }
        }
    }
}