void NewArray (string[] arrayOfString, string[] arrayOfString1)
{
    int j = 0;
    for (int i = 0; i < arrayOfString.Length; i++)
        {
            int b = arrayOfString[i].Length;
            if (b <= 3)
            {
                arrayOfString1[j] = arrayOfString[i];
                j++;
            }
        }
Console.WriteLine("Итоговый массив: ");
Console.WriteLine($"[{string.Join(", ", arrayOfString1)}]");
}

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
string[] arrayOfString1 = new string[count];
NewArray (arrayOfString, arrayOfString1);