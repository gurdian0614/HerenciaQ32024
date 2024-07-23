using HerenciaQ32024;

string tienePatas, esDomestico, esHerbivoro, tieneConcha;
int opcion;

Vertebrado vertebrado = new Vertebrado();
Invertebrado invertebrado = new Invertebrado();

Console.WriteLine("Escoja la clase de animal:");
Console.WriteLine("1. Vertebrado");
Console.WriteLine("2. Invertebrado");
opcion =  Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
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
        }
        else
        {
            vertebrado.EsHerbivoro = false;
            vertebrado.EsCarnivoro = true;
        }

        vertebrado.Imprimir();
        break;

    case 2:
        Console.WriteLine("Ingrese el nombre:");
        invertebrado.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el color:");
        invertebrado.Color = Console.ReadLine();
        Console.WriteLine("Ingrese el tamaño:");
        invertebrado.Tamano = Console.ReadLine();
        Console.WriteLine("Ingrese la Familia perteneciente del animal:");
        invertebrado.Familia = Console.ReadLine();
        Console.WriteLine("Ingrese el tipo de animal:");
        invertebrado.Tipo = Console.ReadLine();
        Console.WriteLine("¿El animal tiene patas? (s/n)");
        tienePatas = Console.ReadLine();

        if (tienePatas == "s")
        {
            invertebrado.TienePatas = true;
            Console.WriteLine("Ingrese el número de patas:");
            invertebrado.NumeroPatas = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("¿El animal tiene concha? (s/n)");
        tieneConcha = Console.ReadLine();

        if (tieneConcha == "s")
        {
            invertebrado.TieneConcha = true;
        }

        invertebrado.Imprimir();
        break;

    default:
        Console.WriteLine("Opción no válida");
        break;
}


