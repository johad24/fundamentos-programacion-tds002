Console.Write("Nombre: ");
string nombre = Console.ReadLine();

Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("Estatura (m): ");
double estatura = double.Parse(Console.ReadLine());

Console.Write("Inicial del apellido: ");
char inicialApellido = Console.ReadLine()[0];

Console.Write("¿Es estudiante activo? (true/false): ");
bool esEstudianteActivo = bool.Parse(Console.ReadLine());

float promedioNotas = 92f;

Console.WriteLine($"\n--- Ficha de datos ---");
Console.WriteLine($"{nombre}, {edad} años, {estatura}m, inicial {inicialApellido}, " +
    $"activo: {esEstudianteActivo}, promedio: {promedioNotas}");

Console.Write("\nPrimer entero: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Segundo entero: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"\nSuma: {a + b}");
Console.WriteLine($"Resta: {a - b}");
Console.WriteLine($"Multiplicación: {a * b}");
Console.WriteLine($"División entera: {a / b}");
Console.WriteLine($"División real: {(double)a / b}");
Console.WriteLine($"Módulo: {a % b}");

Console.WriteLine($"\n{a} > {b}: {a > b}");
Console.WriteLine($"{a} == {b}: {a == b}");
Console.WriteLine($"{a} != {b}: {a != b}");

bool ambosPositivos = (a > 0) && (b > 0);
bool algunoPositivo = (a > 0) || (b > 0);
Console.WriteLine($"\nAmbos positivos (&&): {ambosPositivos}");
Console.WriteLine($"Alguno positivo (||): {algunoPositivo}");

Console.WriteLine("\n--- Precedencia ---");
Console.WriteLine($"5 + 3 * 2 = {5 + 3 * 2}"); // la multiplicación se resuelve antes que la suma
Console.WriteLine($"(5 + 3) * 2 = {(5 + 3) * 2}"); // el paréntesis obliga a sumar primero
Console.WriteLine($"10 / 4 = {10 / 4}"); // al ser dos enteros, se descarta la parte decimal
Console.WriteLine($"10 / 4.0 = {10 / 4.0}"); // con un double en la división, el resultado sí es decimal
Console.WriteLine($"10 % 4 = {10 % 4}"); // el módulo da el residuo de dividir 10 entre 4