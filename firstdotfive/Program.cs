internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        char[] a = new char[10];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = (char)r.Next(0x0041, 0x00D6);
        }
        for (int i = 0; i < a.Length; i++)
        {
            if (i != a.Length - 1)
            {
                if ((a[i + 1] >= 0x0041 && a[i + 1] <= 0x005A) || (a[i + 1] >= 0x0061 && a[i + 1] <= 0x007A))
                {
                    a[i] = ' ';
                    Console.Write(a[i]);
                }
                else Console.Write(a[i]);
            }
            else Console.Write(a[i]);
        }
    }
}