Console.Clear();
Console.WriteLine("--- Ejercicio 1: Tabla de multiplicar ---");
Console.Write("\nIngresa un número: ");
int numeroTabla = int.Parse(Console.ReadLine());

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"{numeroTabla} x {i} = {numeroTabla * i}");
}

if (!Continuar("Ejercicio 2: Menú que no muere")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 2: Menú que no muere ---");

string opcionMenu;
do
{
    Console.WriteLine("\n1. Sumar dos números");
    Console.WriteLine("2. Ver si un número es primo");
    Console.WriteLine("3. Salir");
    Console.Write("Elige una opción: ");
    opcionMenu = Console.ReadLine();

    if (opcionMenu == "1")
    {
        Console.Write("Primer número: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine($"Suma: {x + y}");
    }
    else if (opcionMenu == "2")
    {
        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());
        bool esPrimo = n > 1;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                esPrimo = false;
                break;
            }
        }
        Console.WriteLine($"{n} {(esPrimo ? "es primo" : "no es primo")}");
    }
    else if (opcionMenu != "3")
    {
        Console.WriteLine("Opción inválida.");
    }

} while (opcionMenu != "3");

if (!Continuar("Ejercicio 3: Adivina el número")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 3: Adivina el número ---");

string jugarDeNuevo;
Random random = new Random();
do
{
    int numeroSecreto = random.Next(1, 101);
    int intentos = 0;
    int intentoUsuario;

    Console.WriteLine("\nAdivina el número entre 1 y 100.");
    do
    {
        Console.Write("Tu intento: ");
        intentoUsuario = int.Parse(Console.ReadLine());
        intentos++;

        if (intentoUsuario < numeroSecreto)
            Console.WriteLine("Muy bajo.");
        else if (intentoUsuario > numeroSecreto)
            Console.WriteLine("Muy alto.");
        else
            Console.WriteLine($"¡Correcto! Lo lograste en {intentos} intentos.");

    } while (intentoUsuario != numeroSecreto);

    Console.Write("\n¿Jugar de nuevo? (s/n): ");
    jugarDeNuevo = Console.ReadLine();

} while (jugarDeNuevo == "s");

if (!Continuar("Ejercicio 4: Pirámide")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 4: Pirámide ---");
Console.Write("\nAltura de la pirámide: ");
int altura = int.Parse(Console.ReadLine());

for (int fila = 1; fila <= altura; fila++)
{
    Console.Write(new string(' ', altura - fila));
    Console.WriteLine(new string('*', 2 * fila - 1));
}

if (!Continuar("Ejercicio 5: break y continue")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 5: break y continue ---");
Console.WriteLine();

for (int i = 1; i <= 50; i++)
{
    if (i % 3 == 0)
        continue;

    if (i > 30 && i % 7 == 0)
        break;

    Console.Write(i + " ");
}

Console.WriteLine("\n\nFin del programa.");

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