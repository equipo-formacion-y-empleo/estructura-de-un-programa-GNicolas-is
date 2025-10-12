using System;

void CalculateJulianDate(int day, int month, int year)
{
    int a = (14 - month) / 12;
    int y = year + 4800 - a;
    int m = month + 12 * a - 3;
    double julianDate = day + (153 * m + 2) / 5 + 365 * y + y / 4 - y / 100 + y / 400 - 32045;
    // TODO: Implementar cálculo y mostrar resultados:
    // Console.WriteLine($"Fecha gregoriana: {day}/{month}/{year}");
    // Console.WriteLine($"Fecha juliana: {julianDate:F0}");
    Console.WriteLine($"Fecha gregoriana: {day}/{month}/{year}");
    Console.WriteLine($"Fecha juliana: {julianDate:F0}");
}

// Obtener argumentos de línea de comandos
int day = args.Length > 0 ? int.Parse(args[0]) : 1;
int month = args.Length > 1 ? int.Parse(args[1]) : 1;
int year = args.Length > 2 ? int.Parse(args[2]) : 2000;

// Calcular fecha juliana
CalculateJulianDate(day, month, year);