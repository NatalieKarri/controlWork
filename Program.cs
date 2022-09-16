void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");

string[] array = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
ShowArray(array);