string ShowMessage(string name)
{
   return $"Hola, {name}! Bienvenido al programa."; 
}

Console.WriteLine(ShowMessage(args.Length > 0 ? args[0] : "Maria"));
Console.WriteLine(ShowMessage(args.Length > 1 ? args[1] : "Carlos"));