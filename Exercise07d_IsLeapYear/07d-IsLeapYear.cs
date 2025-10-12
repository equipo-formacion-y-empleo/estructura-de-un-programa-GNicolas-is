bool IsLeapYear(int year)
{
    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int year = int.Parse(args.Length > 0 ? args[0] : "2024");

Console.WriteLine($"¿Es {year} un año bisiesto? {IsLeapYear(year)}");