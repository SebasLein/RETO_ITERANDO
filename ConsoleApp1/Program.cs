using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");

        int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        Console.WriteLine("\n=== ORDEN DESCENDENTE ===");

        for (int i = calificaciones.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");

        int suma = 0;

        foreach (int nota in calificaciones)
        {
            suma += nota;
        }

        double promedio = (double)suma / calificaciones.Length;

        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Promedio: {promedio}");

        Console.WriteLine("\n=== POSICIONES PARES ===");

        for (int i = 0; i < calificaciones.Length; i += 2)
        {
            Console.WriteLine($"Posición par: {calificaciones[i]}");
        }

        Console.WriteLine("\n=== CONTROL DE ACCESO ===");

        int intentos = 0;
        string claveCorrecta = "sena2025";
        string claveIngresada = "";

        while (intentos < 3 && claveIngresada != claveCorrecta)
        {
            Console.Write("Ingresa la clave: ");
            claveIngresada = Console.ReadLine();
            intentos++;

            if (claveIngresada != claveCorrecta)
            {
                if (intentos < 3)
                {
                    Console.WriteLine($"Clave incorrecta. Intentos restantes: {3 - intentos}");
                }
                else
                {
                    Console.WriteLine("Acceso bloqueado.");
                }
            }
            else
            {
                Console.WriteLine("Acceso concedido.");
            }
        }

        Console.WriteLine("\n=== MENÚ PRINCIPAL ===");

        int opcion;
        int mayor = calificaciones[0];

        foreach (int nota in calificaciones)
        {
            if (nota > mayor)
            {
                mayor = nota;
            }
        }

        do
        {
            Console.WriteLine("\n1. Ver promedio del grupo");
            Console.WriteLine("2. Ver calificación más alta");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Promedio del grupo: {promedio}");
                    break;

                case 2:
                    Console.WriteLine($"Calificación más alta: {mayor}");
                    break;

                case 3:
                    Console.WriteLine("Hasta luego.");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

        } while (opcion != 3);

        Console.WriteLine("\n=== PRIMERA CALIFICACIÓN REPROBATORIA ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 60)
            {
                Console.WriteLine($"Encontrada en posición {i + 1}: {calificaciones[i]}");
                break;
            }
        }

        Console.WriteLine("\n=== ESTUDIANTES APROBADOS ===");

        int contadorAprobados = 0;

        foreach (int nota in calificaciones)
        {
            if (nota < 60)
            {
                continue;
            }

            Console.WriteLine($"Aprobado: {nota}");
            contadorAprobados++;
        }

        Console.WriteLine($"Total aprobados: {contadorAprobados}");

        Console.WriteLine("\n=== FILTRO COMBINADO ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 70)
            {
                continue;
            }

            if (calificaciones[i] >= 95)
            {
                Console.WriteLine($"Búsqueda detenida al encontrar: {calificaciones[i]}");
                break;
            }

            Console.WriteLine($"Calificación procesada: {calificaciones[i]}");
        }
    }
}
