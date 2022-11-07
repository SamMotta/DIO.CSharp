/* Operadores de Comparação
    Maior que:  > 
    Menor que:  <
    Maior ou Igual que: >=
    Menor ou Igual que:<=
*/

// Console.WriteLine(5 > 2);
// Console.WriteLine(10 < 4);
// Console.WriteLine(7 >= 67);
// Console.WriteLine(10 <= 10);

// bool Maior = 2 > 5;
int a = 5;
int b = 4;

// if (a > b) {
//     Console.WriteLine("A é maior que B!");
// } else if (b > a) {
//     Console.WriteLine("B é maior que A!");
// } else {
//     Console.WriteLine("A e B são iguais!");
// }

switch (a > b)
{
    case true:
        Console.WriteLine("A é maior que B");
        break;
    default:
        Console.WriteLine("A é menor ou igual a B");
        break;
}