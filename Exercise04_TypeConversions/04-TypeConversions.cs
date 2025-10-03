using System.Data;

double DemoImplicitConversions()
{
    int numero = 17;
    double resultado = numero;
    return resultado;
}
int DemoExplicitConversions()
{
    double numero = 23.89;
    int resultado = (int)numero;
    return resultado;
}

decimal originalValue = decimal.Parse(args.Length > 0 ? args[0] : "23.89");
int targetInt = int.Parse(args.Length > 1 ? args[1] : "17");

Console.WriteLine($"Conversión explícita a int: {DemoExplicitConversions()}");
Console.WriteLine($"Conversión implícita a double: {DemoImplicitConversions()}");