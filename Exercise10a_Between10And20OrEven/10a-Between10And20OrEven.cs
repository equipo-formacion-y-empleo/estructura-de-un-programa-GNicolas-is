using System;

bool Between10And20OrEven(double number)
{
    return (number >= 10 && number <= 20) || (number % 2 == 0);//He puesto esto porque si pusiese if habría que poner return true; y return false; y así es más sencillo y con menos parentesis
}

// Obtener argumentos de línea de comandos
double number = args.Length > 0 ? double.Parse(args[0]) : 15.0;

// Probar la función
bool result = Between10And20OrEven(number);

// Mostrar resultado
Console.WriteLine($"¿{number} está entre 10-20 o es par? {result}");