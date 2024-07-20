using HerenciaQ32024;

string tienePatas, esDomestico, esHerbivoro, esCarnivoro;

Vertebrado vertebrado = new Vertebrado();
Console.WriteLine("Ingrese el nombre:");
vertebrado.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese el color:");
vertebrado.Color = Console.ReadLine();
Console.WriteLine("Ingrese el tamaño:");
vertebrado.Tamano = Console.ReadLine();
Console.WriteLine("Ingrese la Familia perteneciente del animal:");
vertebrado.Familia = Console.ReadLine();
Console.WriteLine("Ingrese el tipo de animal:");
vertebrado.Tipo = Console.ReadLine();
Console.WriteLine("¿El animal tiene patas? (s/n)");
tienePatas = Console.ReadLine();
Console.WriteLine("¿El animal es doméstico? (s/n)");
esDomestico = Console.ReadLine();
Console.WriteLine("¿El animal es herbívoro? (s/n)");
esHerbivoro = Console.ReadLine();

if (tienePatas == "s")
{
    vertebrado.TienePatas = true;
}

if (esDomestico == "s")
{
    vertebrado.EsDomestico = true;
}

if (esHerbivoro == "s")
{
    vertebrado.EsHerbivoro = true;
    vertebrado.EsCarnivoro = false;
} else
{
    vertebrado.EsHerbivoro = false;
    vertebrado.EsCarnivoro = true;
}

vertebrado.Imprimir();