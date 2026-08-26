double saldo = 10000;
int pin = 1234;
int intentosMaximos = 3;

Console.Clear();
Console.WriteLine("--- Cajero Automático ---");

if (!ValidarPin(pin, intentosMaximos))
{
    Console.WriteLine("\nDemasiados intentos fallidos. Tarjeta bloqueada.");
}
else
{
    string opcion;
    do
    {
        MostrarMenu();
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Consultar(saldo);
                break;
            case "2":
                saldo = Depositar(saldo);
                break;
            case "3":
                saldo = Retirar(saldo);
                break;
            case "4":
                Console.WriteLine("\nGracias por usar el cajero.");
                break;
            default:
                Console.WriteLine("\nOpción inválida.");
                break;
        }

    } while (opcion != "4");
}

static bool ValidarPin(int pinCorrecto, int intentosMaximos)
{
    for (int intento = 1; intento <= intentosMaximos; intento++)
    {
        Console.Write($"\nIngresa tu PIN (intento {intento}/{intentosMaximos}): ");
        int pinIngresado = int.Parse(Console.ReadLine());

        if (pinIngresado == pinCorrecto)
        {
            Console.WriteLine("PIN correcto.\n");
            return true;
        }
        Console.WriteLine("PIN incorrecto.");
    }
    return false;
}

static void MostrarMenu()
{
    Console.WriteLine("\n1. Consultar saldo");
    Console.WriteLine("2. Depositar");
    Console.WriteLine("3. Retirar");
    Console.WriteLine("4. Salir");
    Console.Write("Elige una opción: ");
}

static void Consultar(double saldo)
{
    Console.WriteLine($"\nSaldo actual: {saldo:C}");
}

static double Depositar(double saldo)
{
    Console.Write("\nMonto a depositar: ");
    double monto = double.Parse(Console.ReadLine());

    if (monto <= 0)
    {
        Console.WriteLine("El monto debe ser mayor a cero.");
        return saldo;
    }

    saldo += monto;
    Console.WriteLine($"Depósito exitoso. Nuevo saldo: {saldo:C}");
    return saldo;
}

static double Retirar(double saldo)
{
    Console.Write("\nMonto a retirar: ");
    double monto = double.Parse(Console.ReadLine());

    if (monto <= 0)
    {
        Console.WriteLine("El monto debe ser mayor a cero.");
        return saldo;
    }
    if (monto % 100 != 0)
    {
        Console.WriteLine("El monto debe ser múltiplo de 100.");
        return saldo;
    }
    if (monto > saldo)
    {
        Console.WriteLine("Fondos insuficientes.");
        return saldo;
    }

    saldo -= monto;
    Console.WriteLine($"Retiro exitoso. Nuevo saldo: {saldo:C}");
    return saldo;
}