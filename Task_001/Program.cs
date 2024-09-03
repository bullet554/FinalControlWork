void Main()
{
    string[] array = { "1234", "1567", "-2", "computer science" };
    System.Console.WriteLine("Исходный массив: ");
    PrintArray(array);
    CountSymbols(array);
    FilteredArray(array);
}

int CountSymbols(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void FilteredArray(string[] array)
{
    string[] filteredArray = new string[CountSymbols(array)];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            filteredArray[index] = array[i];
            index++;
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Отфильтрованный массив: ");
    PrintArray(filteredArray);
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write(array[i] + "\t");
}


Main();