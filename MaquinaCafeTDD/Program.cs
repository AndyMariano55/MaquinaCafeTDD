using System;

class Program
{
    static void Main()
    {
        // Pruebas TDD
        PruebasTDD.EjecutarPruebas();

        // Inicio de simulación real
        var maquina = new MaquinaDeCafe(
            new Cafetera(50),
            new Azucarero(30),
            new Vasos(5, 5, 5)
        );

        Console.WriteLine("=== MÁQUINA DE CAFÉ ===");

        while (true)
        {
            Console.Write("Seleccione tamaño (pequeño / mediano / grande) o 'salir': ");
            string tamano = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (tamano == "salir")
                break;

            Console.Write("Ingrese cucharadas de azúcar: ");
            if (!int.TryParse(Console.ReadLine(), out int azucar))
            {
                Console.WriteLine("Valor inválido, intente de nuevo.\n");
                continue;
            }

            string resultado = maquina.ServirCafe(tamano, azucar);
            Console.WriteLine(resultado + "\n");
        }

        Console.WriteLine("Gracias por usar la máquina de café ");
    }
}
