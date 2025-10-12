bool IsNotNegative(int number)
{
    if (number >= 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int number = int.Parse(args.Length > 0 ? args[0] : "0");

Console.WriteLine($"¿Es {number} no negativo? {IsNotNegative(number)}");