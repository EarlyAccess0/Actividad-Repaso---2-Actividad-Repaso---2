
using System;

class Program
{
    static void Main()
    {
        string[] nombres = { "Tier 1", "Tier 2", "Tier 3" };
        int[] capacidad = { 22, 15, 20 };
        int[] ventas = { 0, 0, 0 };
        int[] precios = { 500, 400, 300 };
        int[] asientosDisponibles = { capacidad[0], capacidad[1], capacidad[2] };

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"{nombres[i]} {capacidad[i]} Pasajeros Ventas {ventas[i]}, quedan {asientosDisponibles[i]} asientos disponibles");
        }

        VenderPasajes(0, 5, nombres, capacidad, ventas, asientosDisponibles);
        VenderPasajes(1, 3, nombres, capacidad, ventas, asientosDisponibles);
        VenderPasajes(2, 4, nombres, capacidad, ventas, asientosDisponibles);

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"{nombres[i]} {capacidad[i]} Pasajeros Ventas {ventas[i]}, quedan {asientosDisponibles[i]} asientos disponibles");
        }
    }

    static void VenderPasajes(int indice, int cantidad, string[] nombres, int[] capacidad, int[] ventas, int[] asientosDisponibles)
    {
        if (cantidad > asientosDisponibles[indice])
        {
            Console.WriteLine($"No hay suficientes asientos disponibles en {nombres[indice]} para vender {cantidad} pasajes.");
            return;
        }

        ventas[indice] += cantidad;
        asientosDisponibles[indice] -= cantidad;
    }
}