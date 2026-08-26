Console.Clear();
Console.WriteLine("--- Ejercicio 1: Estadísticas ---");

double[] notas = new double[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Nota {i + 1}: ");
    notas[i] = double.Parse(Console.ReadLine());
}

double suma = 0;
double mayor = notas[0];
double menor = notas[0];
foreach (double n in notas)
{
    suma += n;
    if (n > mayor) mayor = n;
    if (n < menor) menor = n;
}
double promedio = suma / notas.Length;

int porEncima = 0;
foreach (double n in notas)
{
    if (n > promedio) porEncima++;
}

Console.WriteLine($"\nPromedio: {promedio:F2}");
Console.WriteLine($"Mayor: {mayor}");
Console.WriteLine($"Menor: {menor}");
Console.WriteLine($"Notas por encima del promedio: {porEncima}");

if (!Continuar("Ejercicio 2: Búsqueda")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 2: Búsqueda ---");

string[] nombres = new string[8];
for (int i = 0; i < 8; i++)
{
    Console.Write($"Nombre {i + 1}: ");
    nombres[i] = Console.ReadLine();
}

Console.Write("\n¿Qué nombre buscas? ");
string buscado = Console.ReadLine();

int posicion = -1;
for (int i = 0; i < nombres.Length; i++)
{
    if (nombres[i] == buscado)
    {
        posicion = i;
        break;
    }
}

if (posicion == -1)
    Console.WriteLine($"'{buscado}' no existe en el arreglo.");
else
    Console.WriteLine($"'{buscado}' está en la posición {posicion}.");

if (!Continuar("Ejercicio 3: Ordenamiento burbuja")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 3: Ordenamiento burbuja ---");

Console.Write("\n¿Cuántos números quieres ordenar? ");
int cantidad = int.Parse(Console.ReadLine());
int[] numeros = new int[cantidad];

for (int i = 0; i < cantidad; i++)
{
    Console.Write($"Número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

int[] copiaParaSort = (int[])numeros.Clone();

Console.WriteLine("\nAntes de ordenar: " + string.Join(", ", numeros));

for (int i = 0; i < numeros.Length - 1; i++)
{
    for (int j = 0; j < numeros.Length - 1 - i; j++)
    {
        if (numeros[j] > numeros[j + 1])
        {
            int temp = numeros[j];
            numeros[j] = numeros[j + 1];
            numeros[j + 1] = temp;
        }
    }
}

Console.WriteLine("Después de ordenar (burbuja): " + string.Join(", ", numeros));

Array.Sort(copiaParaSort);
Console.WriteLine("Con Array.Sort: " + string.Join(", ", copiaParaSort));

if (!Continuar("Ejercicio 4: Invertir")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 4: Invertir ---");

Console.Write("\n¿Cuántos números quieres invertir? ");
int cantidadInvertir = int.Parse(Console.ReadLine());
int[] arregloOriginal = new int[cantidadInvertir];

for (int i = 0; i < cantidadInvertir; i++)
{
    Console.Write($"Número {i + 1}: ");
    arregloOriginal[i] = int.Parse(Console.ReadLine());
}

int[] arregloInvertido = Invertir(arregloOriginal);
Console.WriteLine("\nOriginal: " + string.Join(", ", arregloOriginal));
Console.WriteLine("Invertido: " + string.Join(", ", arregloInvertido));

if (!Continuar("Ejercicio 5: Matriz")) return;

Console.Clear();
Console.WriteLine("--- Ejercicio 5: Matriz 3x3 ---");

int[,] matriz = new int[3, 3];
for (int fila = 0; fila < 3; fila++)
{
    for (int col = 0; col < 3; col++)
    {
        Console.Write($"Elemento [{fila},{col}]: ");
        matriz[fila, col] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\n--- Matriz ---");
for (int fila = 0; fila < 3; fila++)
{
    for (int col = 0; col < 3; col++)
    {
        Console.Write(matriz[fila, col] + "\t");
    }
    Console.WriteLine();
}

int sumaDiagonal = 0;
for (int i = 0; i < 3; i++)
{
    sumaDiagonal += matriz[i, i];
}
Console.WriteLine($"\nSuma de la diagonal principal: {sumaDiagonal}");

Console.WriteLine("\nFin del programa.");

static int[] Invertir(int[] arr)
{
    int[] resultado = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        resultado[i] = arr[arr.Length - 1 - i];
    }
    return resultado;
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
