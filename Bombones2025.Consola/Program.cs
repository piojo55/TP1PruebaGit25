﻿// See https://aka.ms/new-console-template for more information
using Bombones2025.Entidades;
using Bombones2025.Servicios;

//Console.WriteLine("Hello, Paises");
//var paisesServicio = new PaisServicio("Paises.txt");
//List<Pais> paises = paisesServicio.GetPaises();
//foreach (Pais pais in paises)
//{
//    Console.WriteLine(pais.ToString());
//}
//Console.ReadLine();
Console.WriteLine("Hello, Frutos");
var frutossecosServicio = new FrutoSecoServicio("FrutosSecos.txt");
List<FrutoSeco> frutossecos = frutossecosServicio.GetFrutosSecos();
foreach (FrutoSeco frutoseco in frutossecos)
{
    Console.WriteLine(frutoseco.ToString());
}
Console.ReadLine();
