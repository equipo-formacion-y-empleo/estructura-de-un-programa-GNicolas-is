bool CanDrive(int age, bool hasLicense)
{
    if (age >= 18 && hasLicense)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool IsAdult(int age)
{
    if (age >= 18)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int age = int.Parse(args.Length > 0 ? args[0] : "20");
bool hasLicense = bool.Parse(args.Length > 1 ? args[1] : "true");

Console.WriteLine($"¿Puede conducir ({age}, {hasLicense})? {CanDrive(age, hasLicense)}");