string Nome = "Samuel";
Nome = "Daniel";

int Idade = 17;
Idade = 12;

decimal Altura = 1.74M;
Altura = 1.56M;

const bool maiorDeIdade = false;
// maiorDeIdade = true;

DateTime hoje = DateTime.Now;
DateTime amanha = DateTime.Now.AddDays(1);
DateTime depoisAmanha = DateTime.Now.AddDays(2);

Console.WriteLine($"Oi, meu nome é {Nome}, tenho {Idade} anos e {Altura} de altura!");
Console.WriteLine(hoje);
Console.WriteLine(amanha.ToString("dd 'de' MMMM 'de' yyyy"));
Console.WriteLine(depoisAmanha.ToString("d MMMM yyyy"));