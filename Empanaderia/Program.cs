using System;
using Empanaderia.Clases;

namespace Empanaderia
{
    class Program
    {
        static void Main(string[] args)
        {
            var Chef = new Chef();
            Console.WriteLine("Seleccione un tipo de empanada(1.carne, 2.verdura, 3.choclo):");
            var tipo = Console.ReadLine();
            switch (tipo)
            {
                case "1":
                    Console.WriteLine(Chef.PedirEmpanada(new EmpanadaCarne()));
                    break;
                case "2":
                    Console.WriteLine(Chef.PedirEmpanada(new EmpanadaVerdura()));
                    break;
                case "3":
                    Console.WriteLine(Chef.PedirEmpanada(new EmpanadaChoclo()));
                    break;
            }
        }
    }
}
