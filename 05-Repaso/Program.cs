Console.WriteLine("--- Calculadora de viaje ---");

Console.Write("\nDistancia a recorrer (km): ");
double distancia = double.Parse(Console.ReadLine());

Console.Write("Consumo del vehículo (km por galón): ");
double consumo = double.Parse(Console.ReadLine());

Console.Write("Precio del galón: ");
double precioGalon = double.Parse(Console.ReadLine());

Console.Write("Número de pasajeros: ");
int pasajeros = int.Parse(Console.ReadLine());

double galonesNecesarios = distancia / consumo;
double costoTotal = galonesNecesarios * precioGalon;
double costoPorPasajero = costoTotal / pasajeros;

Console.WriteLine($"\nGalones necesarios: {galonesNecesarios:F2}");
Console.WriteLine($"Costo total del combustible: {costoTotal:C}");
Console.WriteLine($"Cada pasajero paga: {costoPorPasajero:C}");
