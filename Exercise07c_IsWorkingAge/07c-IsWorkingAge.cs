bool IsWorkingAge(int age)
{
    if (age >= 16 && age <= 65)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int age = int.Parse(args.Length > 0 ? args[0] : "30");

// Mostrar resultado
Console.WriteLine($"¿Con {age} años se puede trabajar? {IsWorkingAge(age)}");