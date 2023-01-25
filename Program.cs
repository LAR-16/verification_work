

Console.Clear();
Console.WriteLine("Введите данные через пробел: ");
string[] arrayOfString = Console.ReadLine().Split(" ");
Console.WriteLine("Первоначальный массив: ");
Console.WriteLine($"[{string.Join(", ", arrayOfString)}]");
int count = 0;
for (int i = 0; i < arrayOfString.Length; i++)
    {
        int b = arrayOfString[i].Length;
        if (b <= 3)
        {
            count ++;
        }
    }