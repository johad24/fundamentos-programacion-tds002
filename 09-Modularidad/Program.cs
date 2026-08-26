Console.Clear();
Console.WriteLine("--- Menú refactorizado (Ejercicios 1 y 2) ---");

string opcion;
do
{
    MostrarMenu();
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            OpcionSumar();
            break;
        case "2":
            OpcionPrimo();
            break;
        case "3":
            Console.WriteLine("\nSaliendo...");
            break;
        default:
            Console.WriteLine("\nOpción inválida.");
            break;
    }

} while (opcion != "3");

static void MostrarMenu()
{
    Console.WriteLine("\n1. Sumar dos números");
    Console.WriteLine("2. Ver si un número es primo");
    Console.WriteLine("3. Salir");
    Console.Write("Elige una opción: ");
}

static void OpcionSumar()
{
    int x = LeerEntero("Primer número: ");
    int y = LeerEntero("Segundo número: ");
    Console.WriteLine($"Suma: {x + y}");
}

static void OpcionPrimo()
{
    int n = LeerEntero("Ingresa un número: ");
    Console.WriteLine($"{n} {(EsPrimo(n) ? "es primo" : "no es primo")}");
}

static bool EsPrimo(int n)
{
    if (n <= 1) return false;
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0) return false;
    }
    return true;
}

static int LeerEntero(string mensaje)
{
    int valor;
    bool esValido;
    do
    {
        Console.Write(mensaje);
        esValido = int.TryParse(Console.ReadLine(), out valor);
        if (!esValido)
        {
            Console.WriteLine("Entrada inválida, debes escribir un número entero.");
        }
    } while (!esValido);

    return valor;
}