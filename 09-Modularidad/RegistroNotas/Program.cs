List<string> nombres = new List<string>();
List<double> notas = new List<double>();

Console.Clear();
Console.WriteLine("--- Registro de Notas ---");

string opcion;
do
{
    MostrarMenu();
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            AgregarEstudiante(nombres, notas);
            break;
        case "2":
            ListarEstudiantes(nombres, notas);
            break;
        case "3":
            MostrarPromedio(notas);
            break;
        case "4":
            Console.WriteLine("\nSaliendo...");
            break;
        default:
            Console.WriteLine("\nOpción inválida.");
            break;
    }

} while (opcion != "4");

static void MostrarMenu()
{
    Console.WriteLine("\n1. Agregar estudiante");
    Console.WriteLine("2. Listar estudiantes");
    Console.WriteLine("3. Ver promedio del grupo");
    Console.WriteLine("4. Salir");
    Console.Write("Elige una opción: ");
}

static void Volver()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n¿Volver?");
    Console.WriteLine("1 = Sí");
    Console.WriteLine("0 = No");
    Console.Write("Respuesta: ");
    Console.ResetColor();
    Console.ReadLine();

    Console.Clear();
    Console.WriteLine("--- Registro de Notas ---");
}

static void AgregarEstudiante(List<string> nombres, List<double> notas)
{
    Console.Clear();
    Console.WriteLine("--- Agregar estudiante ---");
    Console.Write("\nNombre del estudiante: ");
    string nombre = Console.ReadLine();
    Console.Write("Nota: ");
    double nota = double.Parse(Console.ReadLine());

    nombres.Add(nombre);
    notas.Add(nota);
    Console.WriteLine($"\n{nombre} agregado con nota {nota}.");

    Volver();
}

static void ListarEstudiantes(List<string> nombres, List<double> notas)
{
    Console.Clear();
    Console.WriteLine("--- Lista de estudiantes ---");

    if (nombres.Count == 0)
    {
        Console.WriteLine("\nNo hay estudiantes registrados.");
    }
    else
    {
        for (int i = 0; i < nombres.Count; i++)
        {
            string estado = notas[i] >= 70 ? "Aprobado" : "No aprobado";
            Console.WriteLine($"{nombres[i]} - {notas[i]} - {estado}");
        }
    }

    Volver();
}

static void MostrarPromedio(List<double> notas)
{
    Console.Clear();
    Console.WriteLine("--- Promedio del grupo ---");

    if (notas.Count == 0)
    {
        Console.WriteLine("\nNo hay notas registradas.");
    }
    else
    {
        double suma = 0;
        foreach (double n in notas)
        {
            suma += n;
        }
        double promedio = suma / notas.Count;
        Console.WriteLine($"\nPromedio del grupo: {promedio:F2}");
    }

    Volver();
}