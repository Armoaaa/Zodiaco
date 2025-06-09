using System;
using ZodiacModels;
using ZodiacData; 

namespace ZodiacUI;

public static class ZodiacUI
{
    public static DateTime PedirFechaNacimiento()
    {
        DateTime birthDate;
        while (true)
        {
            Console.Clear();
            DibujarTitulo("CALCULADORA DE SIGNO ZODIACAL");
            Console.Write("Ingrese su fecha de nacimiento (dd/mm/yyyy): ");
            bool valido = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out birthDate);

            if (valido && birthDate.Year > 1900 && birthDate.Year <= DateTime.Now.Year)
            {
                return birthDate;
            }

            Console.WriteLine("\n[!] Formato inválido o fecha no razonable. Presione una tecla para reintentar...");
            Console.ReadKey();
        }
    }

    public static void MostrarSigno(ZodiacSign signo)
    {
        Console.Clear();
        if (signo == null)
        {
            DibujarTitulo("RESULTADO");
            Console.WriteLine("No se encontró un signo para esa fecha.");
        }
        else
        {
            DibujarTitulo($"Tu signo es: {signo.Name}");
            Console.WriteLine($"Rango de fechas: {signo.DateRange}\n");
            Console.WriteLine("Características:");
            foreach (string caracteristica in signo.Characteristics)
            {
                Console.WriteLine($"- {caracteristica}");
            }
        }

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }

    private static void DibujarTitulo(string titulo)
    {
        Console.WriteLine(new string('=', titulo.Length + 4));
        Console.WriteLine($"= {titulo} =");
        Console.WriteLine(new string('=', titulo.Length + 4));
    }
}
