using System;

class DIO
{
    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());

        for (int i = 0; i < qt; i++)
        {
            string[] arrStr = Console.ReadLine().Split(' ');
            string a = arrStr[0];
            string b = arrStr[1];

            if (a.Length < b.Length)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");
        }
    }
}