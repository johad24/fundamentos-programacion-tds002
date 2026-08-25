Console.Clear();
Console.WriteLine("--- Ejercicio 1: Biblioteca matemática ---");

string opcionMenu;
do
{
    Console.WriteLine("\n1. Factorial");
    Console.WriteLine("2. Es primo");
    Console.WriteLine("3. MCD");
    Console.WriteLine("4. Potencia");
    Console.WriteLine("5. Salir");
    Console.Write("Elige una opción: ");
    opcionMenu = Console.ReadLine();

    if (opcionMenu == "1")
    {
        Console.Write("Número: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Factorial de {n} = {Factorial(n)}");
        if (!VolverAEmpezar()) opcionMenu = "5";
        else Console.Clear();
    }
    else if (opcionMenu == "2")
    {
        Console.Write("Número: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"{n} {(EsPrimo(n) ? "es primo" : "no es primo")}");
        if (!VolverAEmpezar()) opcionMenu = "5";
        else Console.Clear();
    }
    else if (opcionMenu == "3")
    {
        Console.Write("Primer número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"MCD de {a} y {b} = {Mcd(a, b)}");
        if (!VolverAEmpezar()) opcionMenu = "5";
        else Console.Clear();
    }
    else if (opcionMenu == "4")
    {
        Console.Write("Base: ");
        double baseNum = double.Parse(Console.ReadLine());
        Console.Write("Exponente: ");
        int exponente = int.Parse(Console.ReadLine());
        Console.WriteLine($"{baseNum}^{exponente} = {Potencia(baseNum, exponente)}");
        if (!VolverAEmpezar()) opcionMenu = "5";
        else Console.Clear();
    }
    else if (opcionMenu != "5")
    {
        Console.WriteLine("Opción inválida.");
    }

} while (opcionMenu != "5");

if (!Continuar("Ejercicio 2: Sobrecarga de Area")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 2: Sobrecarga de Area ---");

Console.Write("\nLado del cuadrado: ");
double ladoCuadrado = double.Parse(Console.ReadLine());
Console.WriteLine($"Área del cuadrado: {Calculadora.Area(ladoCuadrado):F2}");

Console.Write("\nBase del rectángulo: ");
double baseRect = double.Parse(Console.ReadLine());
Console.Write("Altura del rectángulo: ");
double alturaRect = double.Parse(Console.ReadLine());
Console.WriteLine($"Área del rectángulo: {Calculadora.Area(baseRect, alturaRect):F2}");

Console.Write("\nLado A del triángulo: ");
double a1 = double.Parse(Console.ReadLine());
Console.Write("Lado B del triángulo: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Lado C del triángulo: ");
double c1 = double.Parse(Console.ReadLine());
Console.WriteLine($"Área del triángulo: {Calculadora.Area(a1, b1, c1):F2}");

if (!Continuar("Ejercicio 3: Void con propósito")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 3: Void con propósito ---");
Console.Write("\nTítulo a imprimir: ");
string titulo = Console.ReadLine();
Console.WriteLine();
ImprimirTitulo(titulo);

if (!Continuar("Ejercicio 4: Scope")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 4: Scope ---");
DemostrarScope();
// La siguiente línea, si se descomenta, daría error de compilación:
// Console.WriteLine(variableInterna);
// Esto pasa porque "variableInterna" se declaró DENTRO del método
// DemostrarScope() y solo existe mientras ese método se ejecuta.
// Fuera de él, en Main, esa variable no existe: cada método tiene
// su propio espacio de memoria para sus variables locales.

Console.WriteLine("\nFin del programa.");

static long Factorial(int n)
{
    if (n <= 1) return 1;
    long resultado = 1;
    for (int i = 2; i <= n; i++)
    {
        resultado *= i;
    }
    return resultado;
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

static int Mcd(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

static double Potencia(double baseNum, int exponente)
{
    double resultado = 1;
    for (int i = 0; i < exponente; i++)
    {
        resultado *= baseNum;
    }
    return resultado;
}

static void ImprimirLinea(char c, int n)
{
    Console.WriteLine(new string(c, n));
}

static void ImprimirTitulo(string t)
{
    ImprimirLinea('=', t.Length + 4);
    Console.WriteLine($"= {t} =");
    ImprimirLinea('=', t.Length + 4);
}

static void DemostrarScope()
{
    int variableInterna = 42;
    Console.WriteLine($"Dentro del método, variableInterna vale: {variableInterna}");
}

static bool VolverAEmpezar()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n¿Volver a empezar?");
    Console.WriteLine("1 = Sí");
    Console.WriteLine("0 = No");
    Console.Write("Respuesta: ");
    Console.ResetColor();
    int respuesta = int.Parse(Console.ReadLine());
    return respuesta == 1;
}

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

class Calculadora
{
    public static double Area(double lado)
    {
        return lado * lado;
    }

    public static double Area(double baseRect, double altura)
    {
        return baseRect * altura;
    }

    public static double Area(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}