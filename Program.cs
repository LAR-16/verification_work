

Console.Clear();
Console.WriteLine("Введите данные через пробел: ");
string[] arrayOfString = Console.ReadLine().Split(" ");
Console.WriteLine("Первоначальный массив: ");
Console.WriteLine($"[{string.Join(", ", arrayOfString)}]");
