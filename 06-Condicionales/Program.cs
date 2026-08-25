Console.Clear();
Console.WriteLine("--- Ejercicio 1: Calificación ITLA ---");
Console.Write("\nIngresa una nota (0-100): ");
int nota = int.Parse(Console.ReadLine());

if (nota < 0 || nota > 100)
{
    Console.WriteLine("Nota fuera de rango. Debe estar entre 0 y 100.");
}
else
{
    string letra;
    if (nota >= 90) letra = "A";
    else if (nota >= 80) letra = "B";
    else if (nota >= 70) letra = "C";
    else letra = "F";

    string estado = nota >= 70 ? "Aprobó" : "No aprobó";
    Console.WriteLine($"Nota: {nota} -> Letra: {letra} -> {estado}");
}

if (!Continuar("Ejercicio 2: Menú de cafetería")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 2: Menú de cafetería ---");
Console.WriteLine("\n1. Café - RD$60");
Console.WriteLine("2. Croissant - RD$120");
Console.WriteLine("3. Jugo natural - RD$90");
Console.WriteLine("4. Sándwich - RD$150");
Console.WriteLine("5. Ensalada de frutas - RD$100");

Console.Write("\nElige una opción (1-5): ");
int opcion = int.Parse(Console.ReadLine());

double precioUnitario;
string nombreProducto;

switch (opcion)
{
    case 1:
        nombreProducto = "Café";
        precioUnitario = 60;
        break;
    case 2:
        nombreProducto = "Croissant";
        precioUnitario = 120;
        break;
    case 3:
        nombreProducto = "Jugo natural";
        precioUnitario = 90;
        break;
    case 4:
        nombreProducto = "Sándwich";
        precioUnitario = 150;
        break;
    case 5:
        nombreProducto = "Ensalada de frutas";
        precioUnitario = 100;
        break;
    default:
        nombreProducto = "";
        precioUnitario = 0;
        break;
}

if (precioUnitario == 0)
{
    Console.WriteLine("Opción inválida.");
}
else
{
    Console.Write("Cantidad: ");
    int cantidad = int.Parse(Console.ReadLine());
    double totalCafeteria = precioUnitario * cantidad;
    Console.WriteLine($"{cantidad}x {nombreProducto} = {totalCafeteria:C}");
}

if (!Continuar("Ejercicio 3: Triángulo")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 3: Triángulo ---");
Console.Write("\nLado 1: ");
double lado1 = double.Parse(Console.ReadLine());
Console.Write("Lado 2: ");
double lado2 = double.Parse(Console.ReadLine());
Console.Write("Lado 3: ");
double lado3 = double.Parse(Console.ReadLine());

if (lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
{
    Console.WriteLine("Estos lados NO forman un triángulo.");
}
else
{
    string tipo;
    if (lado1 == lado2 && lado2 == lado3) tipo = "Equilátero";
    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3) tipo = "Isósceles";
    else tipo = "Escaleno";

    Console.WriteLine($"Sí forman un triángulo, y es: {tipo}");
}

if (!Continuar("Ejercicio 4: Par o impar con ternario")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 4: Par o impar con ternario ---");
Console.Write("\nIngresa un número: ");
int numero = int.Parse(Console.ReadLine());

string parImpar = numero % 2 == 0 ? "par" : "impar";
Console.WriteLine($"{numero} es {parImpar}");

string signo = numero > 0 ? "positivo" : (numero < 0 ? "negativo" : "cero");
Console.WriteLine($"{numero} es {signo}");

if (!Continuar("Ejercicio 5: Año bisiesto")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 5: Año bisiesto ---");
Console.Write("\nIngresa un año: ");
int anio = int.Parse(Console.ReadLine());

bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
Console.WriteLine($"{anio} {(esBisiesto ? "es" : "no es")} bisiesto");

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