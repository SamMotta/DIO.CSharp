using System;

class DIO
{
    static void Main(string[] args)
    {
        string numero = Console.ReadLine();
        int produto = 1, soma = 0;

        for(int i = 0; i < numero.Length; i++)
        {
            int digito = Convert.ToInt32(numero[i].ToString());
            produto *= digito;
            soma += digito;
        }

        Console.WriteLine(produto - soma);
    }
}