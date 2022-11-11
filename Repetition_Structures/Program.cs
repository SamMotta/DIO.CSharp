
int numero = 5;
int i = 0;

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{numero + " x " + i} = {numero * i}");
// }

while (i <= 10)
{
    if (i == 0) { i++; continue; }
    Console.WriteLine($"{numero + " x " + i} = {numero * i}");
    i++;

    if (i == 6) { break; }
}