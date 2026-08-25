Console.Write("Grados Celsius: ");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = celsius * 9 / 5 + 32;
double kelvin = celsius + 273.15;
Console.WriteLine($"{celsius:F2}°C equivale a {fahrenheit:F2}°F y {kelvin:F2}K");

Console.Write("\nRadio del círculo: ");
double radio = double.Parse(Console.ReadLine());
double areaCirculo = Math.PI * Math.Pow(radio, 2);
double perimetroCirculo = 2 * Math.PI * radio;
Console.WriteLine($"Círculo -> Área: {areaCirculo:F2}, Perímetro: {perimetroCirculo:F2}");

Console.Write("\nBase del rectángulo: ");
double base_ = double.Parse(Console.ReadLine());
Console.Write("Altura del rectángulo: ");
double altura = double.Parse(Console.ReadLine());
double areaRectangulo = base_ * altura;
double perimetroRectangulo = 2 * (base_ + altura);
Console.WriteLine($"Rectángulo -> Área: {areaRectangulo:F2}, Perímetro: {perimetroRectangulo:F2}");

Console.Write("\nMonto en pesos dominicanos: ");
double montoRD = double.Parse(Console.ReadLine());
Console.Write("Tasa de cambio a dólares (ej. 60): ");
double tasaDolar = double.Parse(Console.ReadLine());
Console.Write("Tasa de cambio a euros (ej. 65): ");
double tasaEuro = double.Parse(Console.ReadLine());
Console.WriteLine($"RD${montoRD:F2} equivale a ${montoRD / tasaDolar:F2} y €{montoRD / tasaEuro:F2}");

Console.Write("\nNombre: ");
string nombrePila = Console.ReadLine();
Console.Write("Apellido: ");
string apellido = Console.ReadLine();
string nombreCompleto = $"{nombrePila} {apellido}".ToUpper();
Console.WriteLine($"Nombre completo: {nombreCompleto}");
Console.WriteLine($"Cantidad de letras: {nombreCompleto.Replace(" ", "").Length}");
Console.WriteLine($"Iniciales: {nombrePila.Substring(0, 1)}{apellido.Substring(0, 1)}");
