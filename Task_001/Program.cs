void Main()
{
    string[] array = { "Hello", "2", "world", ":-)" };


    PrintArray(array);
}

void CreatingANewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write(array[i] + "\t");
}


Main();