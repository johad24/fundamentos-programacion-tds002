
List<string> titulos = new List<string>();
List<string> autores = new List<string>();
List<bool> disponibles = new List<bool>();
List<string> prestadoA = new List<string>();

Console.Clear();
Console.WriteLine("=== Sistema de Préstamos de Biblioteca ===");

string opcion;
do
{
    MostrarMenu();
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            AgregarLibro(titulos, autores, disponibles, prestadoA);
            break;
        case "2":
            ListarLibros(titulos, autores, disponibles, prestadoA);
            break;
        case "6":
            Console.WriteLine("\nGracias por usar el sistema.");
            break;
        default:
            Console.WriteLine("\nOpción inválida.");
            break;
    }

} while (opcion != "6");

static void MostrarMenu()
{
    Console.WriteLine("\n1. Agregar libro");
    Console.WriteLine("2. Listar libros");
    Console.WriteLine("3. Prestar libro (próximamente)");
    Console.WriteLine("4. Devolver libro (próximamente)");
    Console.WriteLine("5. Buscar libro (próximamente)");
    Console.WriteLine("6. Salir");
    Console.Write("Elige una opción: ");
}

static void Volver()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n¿Volver al menú principal?");
    Console.WriteLine("1 = Sí");
    Console.WriteLine("0 = No");
    Console.Write("Respuesta: ");
    Console.ResetColor();
    Console.ReadLine();

    Console.Clear();
    Console.WriteLine("=== Sistema de Préstamos de Biblioteca ===");
}

static void AgregarLibro(List<string> titulos, List<string> autores, List<bool> disponibles, List<string> prestadoA)
{
    Console.Clear();
    Console.WriteLine("--- Agregar libro ---");

    Console.Write("\nTítulo del libro: ");
    string titulo = Console.ReadLine();
    Console.Write("Autor: ");
    string autor = Console.ReadLine();

    titulos.Add(titulo);
    autores.Add(autor);
    disponibles.Add(true);
    prestadoA.Add("");

    Console.WriteLine($"\nLibro '{titulo}' agregado al catálogo.");

    Volver();
}

static void ListarLibros(List<string> titulos, List<string> autores, List<bool> disponibles, List<string> prestadoA)
{
    Console.Clear();
    Console.WriteLine("--- Catálogo de libros ---");

    if (titulos.Count == 0)
    {
        Console.WriteLine("\nNo hay libros registrados.");
    }
    else
    {
        for (int i = 0; i < titulos.Count; i++)
        {
            string estado = disponibles[i] ? "Disponible" : $"Prestado a {prestadoA[i]}";
            Console.WriteLine($"{i + 1}. {titulos[i]} - {autores[i]} - {estado}");
        }
    }

    Volver();
}