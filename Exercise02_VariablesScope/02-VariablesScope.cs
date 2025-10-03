float totalSurface = 0;

double CalculateRectangleAreas(double width, double height)
{
    double area = width * height;
    totalSurface += (float)area;
    return area;
}

double area1 = CalculateRectangleAreas(double.Parse(args.Length > 0 ? args[0] : ""), double.Parse(args.Length > 1 ? args[1] : ""));
double area2 = CalculateRectangleAreas(double.Parse(args.Length > 2 ? args[2] : ""), double.Parse(args.Length > 3 ? args[3] : ""));
Console.WriteLine($"Suma total de superficies: {totalSurface}");