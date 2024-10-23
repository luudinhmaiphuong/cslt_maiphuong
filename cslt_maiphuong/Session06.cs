internal class Session_06
{
    public static void Main()
    {
        Question_01();
    }
    public static void Question_01()
    {
        Console.Write("nhap canh thu 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("nhap canh thu 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("nhap canh thu 3: ");
        int c = int.Parse(Console.ReadLine());
        if ( a > 0 && b > 0 && c > 0 )
        {
            if (a == b && b == c)
            {
                Console.WriteLine("tam giac nay la tam giac can");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("tam giac nay la tam giac deu");
            }
            else
            {
                Console.WriteLine("tam giac nay la tam giac binh thuong");
            }
        else ()
        }
        
    }
}
