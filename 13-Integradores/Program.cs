Console.Clear();
Console.WriteLine("--- Ejercicios Integradores ---");

string opcionPrincipal;
do
{
    Console.WriteLine("\n1. Registro de estudiantes");
    Console.WriteLine("2. Ahorcado");
    Console.WriteLine("3. Analizador de texto");
    Console.WriteLine("4. Salir");
    Console.Write("Elige un ejercicio: ");
    opcionPrincipal = Console.ReadLine();

    switch (opcionPrincipal)
    {
        case "1":
            EjecutarRegistroEstudiantes();
            break;
        case "2":
            EjecutarAhorcado();
            break;
        case "3":
            EjecutarAnalizadorTexto();
            break;
        case "4":
            Console.WriteLine("\nSaliendo...");
            break;
        default:
            Console.WriteLine("\nOpción inválida.");
            break;
    }

} while (opcionPrincipal != "4");


// ===== Ejercicio 1: Registro de estudiantes =====

static void EjecutarRegistroEstudiantes()
{
    Console.Clear();
    Console.WriteLine("--- Registro de estudiantes ---");

    List<string> nombres = new List<string>();
    List<double> notas = new List<double>();

    string opcion;
    do
    {
        Console.WriteLine("\n1. Agregar estudiante");
        Console.WriteLine("2. Buscar por nombre");
        Console.WriteLine("3. Ver promedio del grupo");
        Console.WriteLine("4. Mostrar aprobados");
        Console.WriteLine("5. Salir");
        Console.Write("Elige una opción: ");
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.Write("Nombre: ");
                nombres.Add(Console.ReadLine());
                Console.Write("Nota: ");
                notas.Add(double.Parse(Console.ReadLine()));
                Console.WriteLine("Estudiante agregado.");
                break;
            case "2":
                Console.Write("Nombre a buscar: ");
                string buscado = Console.ReadLine();
                int indice = nombres.IndexOf(buscado);
                if (indice == -1)
                    Console.WriteLine("No encontrado.");
                else
                    Console.WriteLine($"{nombres[indice]} tiene nota {notas[indice]}.");
                break;
            case "3":
                if (notas.Count == 0)
                {
                    Console.WriteLine("No hay estudiantes.");
                }
                else
                {
                    double suma = 0;
                    foreach (double n in notas) suma += n;
                    Console.WriteLine($"Promedio del grupo: {(suma / notas.Count):F2}");
                }
                break;
            case "4":
                Console.WriteLine("\n--- Aprobados (nota >= 70) ---");
                bool hayAprobados = false;
                for (int i = 0; i < nombres.Count; i++)
                {
                    if (notas[i] >= 70)
                    {
                        Console.WriteLine($"{nombres[i]} - {notas[i]}");
                        hayAprobados = true;
                    }
                }
                if (!hayAprobados) Console.WriteLine("Nadie ha aprobado todavía.");
                break;
            case "5":
                Console.WriteLine("\nVolviendo al menú principal...");
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }

    } while (opcion != "5");
}


// ===== Ejercicio 2: Ahorcado =====

static void EjecutarAhorcado()
{
    Console.Clear();
    Console.WriteLine("--- Ahorcado ---");

    string[] palabras = { "programacion", "variable", "metodo", "arreglo", "compilador" };
    Random random = new Random();
    string palabraSecreta = palabras[random.Next(palabras.Length)];

    char[] progreso = new char[palabraSecreta.Length];
    for (int i = 0; i < progreso.Length; i++) progreso[i] = '_';

    int vidas = 6;
    List<char> letrasUsadas = new List<char>();

    while (vidas > 0 && new string(progreso) != palabraSecreta)
    {
        Console.WriteLine($"\nPalabra: {new string(progreso)}");
        Console.WriteLine($"Vidas restantes: {vidas}");
        Console.Write("Adivina una letra: ");
        char letra = Console.ReadLine()[0];

        if (letrasUsadas.Contains(letra))
        {
            Console.WriteLine("Ya usaste esa letra.");
            continue;
        }
        letrasUsadas.Add(letra);

        if (palabraSecreta.Contains(letra))
        {
            for (int i = 0; i < palabraSecreta.Length; i++)
            {
                if (palabraSecreta[i] == letra) progreso[i] = letra;
            }
            Console.WriteLine("¡Correcto!");
        }
        else
        {
            vidas--;
            Console.WriteLine("Letra incorrecta.");
        }
    }

    if (new string(progreso) == palabraSecreta)
        Console.WriteLine($"\n¡Ganaste! La palabra era: {palabraSecreta}");
    else
        Console.WriteLine($"\nPerdiste. La palabra era: {palabraSecreta}");
}


// ===== Ejercicio 3: Analizador de texto =====

static void EjecutarAnalizadorTexto()
{
    Console.Clear();
    Console.WriteLine("--- Analizador de texto ---");

    Console.Write("\nEscribe una frase: ");
    string frase = Console.ReadLine();

    int cantidadPalabras = ContarPalabras(frase);
    int cantidadVocales = ContarVocales(frase);
    int cantidadConsonantes = ContarConsonantes(frase);
    string palabraMasLarga = ObtenerPalabraMasLarga(frase);

    Console.WriteLine($"\nCantidad de palabras: {cantidadPalabras}");
    Console.WriteLine($"Cantidad de vocales: {cantidadVocales}");
    Console.WriteLine($"Cantidad de consonantes: {cantidadConsonantes}");
    Console.WriteLine($"Palabra más larga: {palabraMasLarga}");
}

static int ContarPalabras(string frase)
{
    string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return palabras.Length;
}

static int ContarVocales(string frase)
{
    string vocales = "aeiouAEIOU";
    int contador = 0;
    foreach (char c in frase)
    {
        if (vocales.Contains(c)) contador++;
    }
    return contador;
}

static int ContarConsonantes(string frase)
{
    int contador = 0;
    foreach (char c in frase)
    {
        if (char.IsLetter(c) && !"aeiouAEIOU".Contains(c)) contador++;
    }
    return contador;
}

static string ObtenerPalabraMasLarga(string frase)
{
    string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string masLarga = "";
    foreach (string p in palabras)
    {
        if (p.Length > masLarga.Length) masLarga = p;
    }
    return masLarga;
}
