Console.Clear();
Console.WriteLine("--- Ejercicio 1: Lista de tareas ---");

List<string> tareas = new List<string>();
string opcionTareas;
do
{
    Console.WriteLine("\n1. Agregar tarea");
    Console.WriteLine("2. Eliminar tarea");
    Console.WriteLine("3. Marcar como hecha");
    Console.WriteLine("4. Listar tareas");
    Console.WriteLine("5. Salir");
    Console.Write("Elige una opción: ");
    opcionTareas = Console.ReadLine();

    if (opcionTareas == "1")
    {
        Console.Write("Nueva tarea: ");
        tareas.Add(Console.ReadLine());
        Console.WriteLine("Tarea agregada.");
    }
    else if (opcionTareas == "2")
    {
        Console.Write("Número de tarea a eliminar: ");
        int indice = int.Parse(Console.ReadLine()) - 1;
        if (indice >= 0 && indice < tareas.Count)
        {
            tareas.RemoveAt(indice);
            Console.WriteLine("Tarea eliminada.");
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }
    }
    else if (opcionTareas == "3")
    {
        Console.Write("Número de tarea completada: ");
        int indice = int.Parse(Console.ReadLine()) - 1;
        if (indice >= 0 && indice < tareas.Count)
        {
            tareas[indice] = "[x] " + tareas[indice];
            Console.WriteLine("Tarea marcada como hecha.");
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }
    }
    else if (opcionTareas == "4")
    {
        Console.WriteLine("\n--- Lista de tareas ---");
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas.");
        }
        else
        {
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }
    }
    else if (opcionTareas != "5")
    {
        Console.WriteLine("Opción inválida.");
    }

} while (opcionTareas != "5");

if (!Continuar("Ejercicio 2: Arreglo vs Lista")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 2: Arreglo vs Lista ---");

Console.Write("\n¿Cuántos nombres vas a guardar? ");
int cantidadNombres = int.Parse(Console.ReadLine());

// Con arreglo: el tamaño queda fijo desde el inicio
string[] nombresArreglo = new string[cantidadNombres];
for (int i = 0; i < cantidadNombres; i++)
{
    Console.Write($"Nombre {i + 1} (arreglo): ");
    nombresArreglo[i] = Console.ReadLine();
}
Console.WriteLine("Arreglo: " + string.Join(", ", nombresArreglo));

// Con lista: se puede seguir agregando después, sin definir tamaño fijo
List<string> nombresLista = new List<string>();
for (int i = 0; i < cantidadNombres; i++)
{
    Console.Write($"Nombre {i + 1} (lista): ");
    nombresLista.Add(Console.ReadLine());
}
Console.WriteLine("Lista: " + string.Join(", ", nombresLista));
// Diferencia: el arreglo tiene tamaño fijo (cantidadNombres) desde su creación.
// La lista puede crecer o achicarse después con Add() o Remove(),
// sin necesidad de saber el tamaño final de antemano.

if (!Continuar("Ejercicio 3: Filtro")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 3: Filtro ---");

Random random = new Random();
List<int> numerosAleatorios = new List<int>();
for (int i = 0; i < 15; i++)
{
    numerosAleatorios.Add(random.Next(1, 101));
}

List<int> pares = new List<int>();
List<int> mayoresA50 = new List<int>();
foreach (int n in numerosAleatorios)
{
    if (n % 2 == 0) pares.Add(n);
    if (n > 50) mayoresA50.Add(n);
}

Console.WriteLine("\nNúmeros generados: " + string.Join(", ", numerosAleatorios));
Console.WriteLine($"Cantidad de pares: {pares.Count}");
Console.WriteLine($"Cantidad mayores a 50: {mayoresA50.Count}");

if (!Continuar("Ejercicio 4: Sin repetidos")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 4: Sin repetidos ---");

List<string> palabrasSinRepetir = new List<string>();
string palabra;
do
{
    Console.Write("\nEscribe una palabra (o 'fin' para terminar): ");
    palabra = Console.ReadLine();

    if (palabra != "fin")
    {
        if (!palabrasSinRepetir.Contains(palabra))
        {
            palabrasSinRepetir.Add(palabra);
        }
        else
        {
            Console.WriteLine("Esa palabra ya está en la lista.");
        }
    }

} while (palabra != "fin");

palabrasSinRepetir.Sort();
Console.WriteLine("\nLista ordenada sin repetidos: " + string.Join(", ", palabrasSinRepetir));

Console.WriteLine("\nFin del programa.");

static bool Continuar(string siguienteEjercicio)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\n¿Quiere continuar con {siguienteEjercicio}?");
    Console.WriteLine("0 = No");
    Console.WriteLine("1 = Sí");
    Console.Write("Respuesta: ");
    Console.ResetColor();
    int respuesta = int.Parse(Console.ReadLine());
    return respuesta == 1;
}