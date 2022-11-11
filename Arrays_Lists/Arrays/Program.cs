int[] arrayInt = new int[3];

arrayInt[0] = 10;
arrayInt[1] = 21;
arrayInt[2] = 32;

// Não é possível!
// arrayInt[3] = 4; 

Console.WriteLine("Usando FOR");
for (int i = 0; i < arrayInt.Length; i++)
{
    Console.WriteLine(arrayInt[i]);
}

// Console.WriteLine("Array agora tem 6 índices!");

// Redimensionando o array - Não é necessário usar generic
// Array.Resize<int>(ref arrayInt, 6);
// arrayInt[3] = 43;
// arrayInt[4] = 54;
// arrayInt[5] = 64;

// Copiando para um Array maior!
int[] arrayIntMaior = new int[6];
Array.Copy(arrayInt, arrayIntMaior, arrayInt.Length);
arrayIntMaior[3] = 43;
arrayIntMaior[4] = 54;
arrayIntMaior[5] = 64;


Console.WriteLine("Usando FOREACH");
foreach (int i in arrayIntMaior)
{
    Console.WriteLine(i);
}

