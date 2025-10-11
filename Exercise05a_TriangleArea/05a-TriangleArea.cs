using System.Formats.Asn1;

double CalculateTriangleArea()
{
    double Base = 8.5;
    double Altura = 3.2;
    return (Base * Altura) / 2;
}

double triangleBase = double.Parse(args.Length > 0 ? args[0] : "6.0");
double triangleHeight = double.Parse(args.Length > 1 ? args[1] : "4.0");

Console.WriteLine($"Área del triángulo: {CalculateTriangleArea():F2}");
