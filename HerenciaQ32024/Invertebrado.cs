
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace HerenciaQ32024
{
    public class Invertebrado : Animal
    {
        public string Tipo { get; set; }

        public bool TienePatas { get; set; }

        public int NumeroPatas { get; set; }

        public bool TieneConcha { get; set; }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Tiene Patas: {(TienePatas ? "Si" : "No")}");

            if (TienePatas)
            {
                Console.WriteLine($"Número de patas: {NumeroPatas}");
            }

            Console.WriteLine($"Tiene Concha: {(TieneConcha ? "Si" : "No")}");
        }
    }
}
