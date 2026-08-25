Console.Clear();
Console.WriteLine("--- Programa de venta ---");
Console.Write("\nNombre del cliente: ");
string cliente = Console.ReadLine();

Console.Write("\n¿Cuántos productos? ");
int cantidadProductos = int.Parse(Console.ReadLine());

string[] nombres = new string[cantidadProductos];
double[] precios = new double[cantidadProductos];
double[] cantidades = new double[cantidadProductos];
double[] subtotales = new double[cantidadProductos];

for (int i = 0; i < cantidadProductos; i++)
{
    Console.Write($"\nProducto {i + 1} - nombre: ");
    nombres[i] = Console.ReadLine();
    Console.Write($"Producto {i + 1} - precio: ");
    precios[i] = double.Parse(Console.ReadLine());
    Console.Write($"Producto {i + 1} - cantidad: ");
    cantidades[i] = double.Parse(Console.ReadLine());
    subtotales[i] = precios[i] * cantidades[i];
}

double subtotal = 0;
for (int i = 0; i < cantidadProductos; i++)
{
    subtotal += subtotales[i];
}
double itbis = subtotal * 0.18;
double total = subtotal + itbis;

Console.WriteLine($"\n--- Factura de {cliente} ---");
for (int i = 0; i < cantidadProductos; i++)
{
    Console.WriteLine($"{nombres[i],-15}{cantidades[i],5}{precios[i],10:C}{subtotales[i],12:C}");
}
Console.WriteLine($"{"Subtotal:",-30}{subtotal,17:C}");
Console.WriteLine($"{"ITBIS (18%):",-30}{itbis,17:C}");
Console.WriteLine($"{"Total:",-30}{total,17:C}");

if (!Continuar("Programa de nómina")) return;

Console.Clear();
Console.WriteLine("--- Programa de nómina ---");
Console.Write("\nHoras trabajadas: ");
double horas = double.Parse(Console.ReadLine());
Console.Write("Tarifa por hora: ");
double tarifa = double.Parse(Console.ReadLine());

double salarioBruto = horas * tarifa;
double afp = salarioBruto * 0.0287;
double sfs = salarioBruto * 0.0304;
double salarioNeto = salarioBruto - afp - sfs;

Console.WriteLine($"\n--- Nómina ---");
Console.WriteLine($"Salario bruto: {salarioBruto:C}");
Console.WriteLine($"Descuento AFP (2.87%): {afp:C}");
Console.WriteLine($"Descuento SFS (3.04%): {sfs:C}");
Console.WriteLine($"Salario neto: {salarioNeto:C}");

if (!Continuar("Programa del reloj")) return;

Console.Clear();
Console.WriteLine("--- Programa del reloj ---");
Console.Write("\nCantidad de segundos: ");
int segundosTotales = int.Parse(Console.ReadLine());
int horasReloj = segundosTotales / 3600;
int minutosReloj = (segundosTotales % 3600) / 60;
int segundosReloj = segundosTotales % 60;

Console.WriteLine($"\n--- Reloj ---");
Console.WriteLine($"{segundosTotales} segundos equivalen a {horasReloj}h {minutosReloj}m {segundosReloj}s");

Console.WriteLine("\nFin del programa.");

static bool Continuar(string siguientePrograma)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\n¿Quiere continuar con {siguientePrograma}?");
    Console.WriteLine("0 = No");
    Console.WriteLine("1 = Sí");
    Console.Write("Respuesta: ");
    Console.ResetColor();
    int respuesta = int.Parse(Console.ReadLine());
    return respuesta == 1;
}