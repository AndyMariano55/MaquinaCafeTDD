using System;

public class PruebasTDD
{
    public static void EjecutarPruebas()
    {
        Console.WriteLine("=== EJECUTANDO PRUEBAS TDD ===");

        var maquina = new MaquinaDeCafe(
            new Cafetera(10),
            new Azucarero(10),
            new Vasos(5, 5, 5)
        );

        Probar(
            "Debe servir café correctamente",
            maquina.ServirCafe("mediano", 2),
            "Aquí tienes tu café mediano con 2 cucharadas de azúcar "
        );

        var sinVasos = new MaquinaDeCafe(
            new Cafetera(10),
            new Azucarero(10),
            new Vasos(0, 0, 0)
        );
        Probar(
            "Debe mostrar mensaje si no hay vasos",
            sinVasos.ServirCafe("pequeño", 1),
            "No hay vasos disponibles."
        );

        var sinCafe = new MaquinaDeCafe(
            new Cafetera(0),
            new Azucarero(10),
            new Vasos(5, 5, 5)
        );
        Probar(
            "Debe mostrar mensaje si no hay café",
            sinCafe.ServirCafe("grande", 1),
            "No hay café suficiente."
        );

        var sinAzucar = new MaquinaDeCafe(
            new Cafetera(10),
            new Azucarero(0),
            new Vasos(5, 5, 5)
        );
        Probar(
            "Debe mostrar mensaje si no hay azúcar",
            sinAzucar.ServirCafe("mediano", 2),
            "No hay azúcar suficiente."
        );

        Console.WriteLine("=== PRUEBAS COMPLETADAS ===\n");
    }

    private static void Probar(string descripcion, string resultado, string esperado)
    {
        bool exito = resultado == esperado;
        Console.ForegroundColor = exito ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine($"[{(exito ? "✔" : "✘")}] {descripcion}");
        Console.ResetColor();

        if (!exito)
        {
            Console.WriteLine($"   Esperado: {esperado}");
            Console.WriteLine($"   Obtenido: {resultado}");
        }
    }
}
