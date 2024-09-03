void Main()
{
    string[] array = { "Hello", "2", "world", ":-)" };


    PrintArray(array);
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write(array[i] + "\t");
}


Main();