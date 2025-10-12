double balance = 0.0;
void Deposit_1(double amount)
{
    balance += amount;
}
void Deposit_2(double amount)
{
    balance += amount;
}
void Withdraw_1(double amount)
{
    balance -= amount;
}
void Withdraw_2(double amount)
{
    balance -= amount;
}
void ApplyInterest(double factor)
{
    balance *= factor;
}
void ApplyCommission(double factor)
{
    balance /= factor;
}

// Saldo inicial: 1000.0
balance = double.Parse(args.Length > 0 ? args[0] : "1000,0");
Console.WriteLine($"Saldo inicial: {balance:F2}");

// Depósito 1: 250.50
Deposit_1(double.Parse(args.Length > 1 ? args[1] : "250,50"));
Console.WriteLine($"Después del depósito 1: {balance:F2}");

// Depósito 2: 100.0
Deposit_2(double.Parse(args.Length > 2 ? args[2] : "100,0"));
Console.WriteLine($"Después del depósito 2: {balance:F2}");

// Retiro 1: 75.25
Withdraw_1(double.Parse(args.Length > 3 ? args[3] : "75,25"));
Console.WriteLine($"Después del retiro 1: {balance:F2}");

// Retiro 2: 50.0
Withdraw_2(double.Parse(args.Length > 4 ? args[4] : "50,0"));
Console.WriteLine($"Después del retiro 2: {balance:F2}");

// Intereses: 2%
ApplyInterest(double.Parse(args.Length > 5 ? args[5] : "1,02"));
Console.WriteLine($"Después de intereses: {balance:F2}");

// Comisión: 1%
ApplyCommission(double.Parse(args.Length > 6 ? args[6] : "1,01"));
Console.WriteLine($"Saldo tras comisiones: {balance:F2}");