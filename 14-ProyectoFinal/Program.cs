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
        case "3":
            PrestarLibro(titulos, disponibles, prestadoA);
            break;
        case "4":
            DevolverLibro(titulos, disponibles, prestadoA);
            break;
        case "5":
            BuscarLibro(titulos, autores, disponibles, prestadoA);
            break;
        case "6":
            EliminarLibro(titulos, autores, disponibles, prestadoA);
            break;
        case "7":
            Console.WriteLine("\nGracias por usar el sistema.");
            break;
        default:
            Console.WriteLine("\nOpción inválida.");
            break;
    }

} while (opcion != "7");

static void MostrarMenu()
{
    Console.WriteLine("\n1. Agregar libro");
    Console.WriteLine("2. Listar libros");
    Console.WriteLine("3. Prestar libro");
    Console.WriteLine("4. Devolver libro");
    Console.WriteLine("5. Buscar libro");
    Console.WriteLine("6. Eliminar libro");
    Console.WriteLine("7. Salir");
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

static void PrestarLibro(List<string> titulos, List<bool> disponibles, List<string> prestadoA)
{
    Console.Clear();
    Console.WriteLine("--- Prestar libro ---");

    if (titulos.Count == 0)
    {
        Console.WriteLine("\nNo hay libros registrados.");
        Volver();
        return;
    }

    Console.WriteLine();
    for (int i = 0; i < titulos.Count; i++)
    {
        if (disponibles[i])
        {
            Console.WriteLine($"{i + 1}. {titulos[i]}");
        }
    }

    Console.Write("\nNúmero del libro a prestar: ");
    int numero;
    bool esValido = int.TryParse(Console.ReadLine(), out numero);
    int indice = numero - 1;

    if (!esValido || indice < 0 || indice >= titulos.Count)
    {
        Console.WriteLine("Número inválido.");
    }
    else if (!disponibles[indice])
    {
        Console.WriteLine("Ese libro ya está prestado.");
    }
    else
    {
        Console.Write("Nombre de la persona: ");
        string nombre = Console.ReadLine();

        disponibles[indice] = false;
        prestadoA[indice] = nombre;

        Console.WriteLine($"\n'{titulos[indice]}' prestado a {nombre}.");
    }

    Volver();
}

static void DevolverLibro(List<string> titulos, List<bool> disponibles, List<string> prestadoA)
{
    Console.Clear();
    Console.WriteLine("--- Devolver libro ---");

    if (titulos.Count == 0)
    {
        Console.WriteLine("\nNo hay libros registrados.");
        Volver();
        return;
    }

    Console.WriteLine();
    bool hayPrestados = false;
    for (int i = 0; i < titulos.Count; i++)
    {
        if (!disponibles[i])
        {
            Console.WriteLine($"{i + 1}. {titulos[i]} - Prestado a {prestadoA[i]}");
            hayPrestados = true;
        }
    }

    if (!hayPrestados)
    {
        Console.WriteLine("No hay libros prestados actualmente.");
        Volver();
        return;
    }

    Console.Write("\nNúmero del libro a devolver: ");
    int numero;
    bool esValido = int.TryParse(Console.ReadLine(), out numero);
    int indice = numero - 1;

    if (!esValido || indice < 0 || indice >= titulos.Count)
    {
        Console.WriteLine("Número inválido.");
    }
    else if (disponibles[indice])
    {
        Console.WriteLine("Ese libro no estaba prestado.");
    }
    else
    {
        Console.WriteLine($"\n'{titulos[indice]}' devuelto por {prestadoA[indice]}.");
        disponibles[indice] = true;
        prestadoA[indice] = "";
    }

    Volver();
}

static void BuscarLibro(List<string> titulos, List<string> autores, List<bool> disponibles, List<string> prestadoA)
{
    Console.Clear();
    Console.WriteLine("--- Buscar libro ---");

    if (titulos.Count == 0)
    {
        Console.WriteLine("\nNo hay libros registrados.");
        Volver();
        return;
    }

    Console.Write("\nTítulo a buscar: ");
    string buscado = Console.ReadLine();

    bool encontrado = false;
    for (int i = 0; i < titulos.Count; i++)
    {
        if (titulos[i].ToLower().Contains(buscado.ToLower()))
        {
            string estado = disponibles[i] ? "Disponible" : $"Prestado a {prestadoA[i]}";
            Console.WriteLine($"\n{titulos[i]} - {autores[i]} - {estado}");
            encontrado = true;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("\nNo se encontró ningún libro con ese título.");
    }

    Volver();
}

static void EliminarLibro(List<string> titulos, List<string> autores, List<bool> disponibles, List<string> prestadoA)
{
    Console.Clear();
    Console.WriteLine("--- Eliminar libro ---");

    if (titulos.Count == 0)
    {
        Console.WriteLine("\nNo hay libros registrados.");
        Volver();
        return;
    }

    Console.WriteLine();
    for (int i = 0; i < titulos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {titulos[i]} - {autores[i]}");
    }

    Console.Write("\nNúmero del libro a eliminar: ");
    int numero;
    bool esValido = int.TryParse(Console.ReadLine(), out numero);
    int indice = numero - 1;

    if (!esValido || indice < 0 || indice >= titulos.Count)
    {
        Console.WriteLine("Número inválido.");
    }
    else if (!disponibles[indice])
    {
        Console.WriteLine($"'{titulos[indice]}' está prestado a {prestadoA[indice]}.");
        Console.Write("Razón para dar de baja al libro: ");
        string razon = Console.ReadLine();

        string tituloEliminado = titulos[indice];
        titulos.RemoveAt(indice);
        autores.RemoveAt(indice);
        disponibles.RemoveAt(indice);
        prestadoA.RemoveAt(indice);

        Console.WriteLine($"\n'{tituloEliminado}' dado de baja. Razón: {razon}");
    }
    else
    {
        string tituloEliminado = titulos[indice];
        titulos.RemoveAt(indice);
        autores.RemoveAt(indice);
        disponibles.RemoveAt(indice);
        prestadoA.RemoveAt(indice);

        Console.WriteLine($"\n'{tituloEliminado}' eliminado del catálogo.");
    }

    Volver();
}