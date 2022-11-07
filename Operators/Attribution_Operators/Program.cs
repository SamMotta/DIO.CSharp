// int a = 10;
// int b = 20;

// int c = a + b;
// Console.WriteLine(c);

// c += 5;
// c -= 5;
// c *= 5;
// c /= 5;

// Console.WriteLine(c);

// Cast - Casting
// Convert.ToSingle(c);
// int.Parse("10");
//double.Parse("10,2");

/* Diferença do Convert para o Parse:
    * Não aceita null!
    int.Parse(null);
    
    * Aceita null e devolve 0!
    Convert.ToInt32(null);
*/

// Cast Implícito

// Funciona
// int a = 5;
// double b = a;

// Não funciona
// double a = 5.5;
// int b = a;

// Console.WriteLine(b);


string a = "-16";
// int b = 0;

// No caso de a não ser convertido, b é a saída; É possível criar a varível dentro do TryParse().
int.TryParse(a, out int b);

Console.WriteLine(b);
