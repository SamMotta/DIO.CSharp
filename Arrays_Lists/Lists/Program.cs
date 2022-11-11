
List<string> nomes = new List<string>(); 

nomes.Add("Samuel");
nomes.Add("André");
nomes.Add("Ryan");
nomes.Add("Chico");

nomes.Remove("Samuel");
foreach(string i in nomes) 
{
    Console.WriteLine(i);
}