float DistanceBetweenPoints(float x1, float y1, float x2, float y2)
{
    return (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 + y1, 2)); 
}

float x1 = float.Parse(args.Length > 0 ? args[0] : "0,0");
float y1 = float.Parse(args.Length > 1 ? args[1] : "0,0");
float x2 = float.Parse(args.Length > 2 ? args[2] : "3,0");
float y2 = float.Parse(args.Length > 3 ? args[3] : "4,0");

Console.WriteLine($"Distance: {DistanceBetweenPoints(x1, y1, x2, y2)}");