using System.Reflection.PortableExecutable;

void DemoBasicDataTypes()
{
    int old = 25;
    float class_Note = 7.6f;
    double account = 23.45;
    char initial = 'C';
    string name = "Nicolas";
    bool is_Estudent = true;
    Console.WriteLine($"Old: {old}");
    Console.WriteLine($"Clase Note: {class_Note}");
    Console.WriteLine($"Account: {account}");
    Console.WriteLine($"Initial: {initial}");
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Is Estudent: {is_Estudent}");
}

void ShowDataTypeSizes()
{
    Console.WriteLine($"int: {sizeof(int)} bites");
    Console.WriteLine($"float: {sizeof(float)} bites");
    Console.WriteLine($"double: {sizeof(double)} bites");
    Console.WriteLine($"char: {sizeof(char)} bites");
    Console.WriteLine($"bool: {sizeof(bool)} bites");
}

DemoBasicDataTypes();
ShowDataTypeSizes();