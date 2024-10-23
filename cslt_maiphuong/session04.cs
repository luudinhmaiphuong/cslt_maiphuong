internal class Session_04
{
    public static void Main()
    {
        Question_01();
    }
    public static void Question_01()
        //chay so tu 1-10, doan so dung theo may da chon
    {
        Random rnd = new Random();
        int comp_num = rnd.Next(0, 10) + 1;
        Console.Write(comp_num"Ban doan so may?")
    }