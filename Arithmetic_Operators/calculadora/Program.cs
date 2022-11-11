using calculadora.models;

Calculadora calc = new Calculadora();

double a = 6.5;
double b = 7;

calc.setNumbers(a, b);
calc.Radiciação();

Console.WriteLine($"{calc.getResult()}");