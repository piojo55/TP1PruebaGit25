// See https://aka.ms/new-console-template for more information
using Bombones2025.Entidades;
using Bombones2025.Servicios;
using System.Globalization;

bool continuar = true;



while (continuar == true) 
    {
    Console.WriteLine("Ingrese la opcion a listar");
    Console.WriteLine("1. Paises");
    Console.WriteLine("2. Frutos Secos");
    Console.WriteLine("3. Salir");
    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            Console.WriteLine("Lista Paises");
            var paisesServicio = new PaisServicio("Paises.txt");
            List<Pais> paises = paisesServicio.GetPaises();
            foreach (Pais pais in paises)
            {
                Console.WriteLine(pais.ToString());
            }
            Console.WriteLine();
            break;
        case "2":
            Console.WriteLine("Lista Frutos Secos");
            var frutossecosServicio = new FrutoSecoServicio("FrutosSecos.txt");
            List<FrutoSeco> frutossecos = frutossecosServicio.GetFrutosSecos();
            foreach (FrutoSeco frutoseco in frutossecos)
            {
                Console.WriteLine(frutoseco.ToString());
            }
            Console.WriteLine();
            break;
        case "3":
            Console.WriteLine("Salir");
            continuar = false;
            break;
        default:
            Console.WriteLine("Número fuera del rango.");
            Console.WriteLine();
            break;


    }


}






