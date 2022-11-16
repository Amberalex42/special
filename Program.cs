string[] sample = {"hello", "2", "world", ":-)"};

string[] FilterArray(string[] array)
{
    string[] result = new string[array.Length];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[k] = array[i];
            k += 1;
        }
    }
    return result;
}
void PrintArray(string[] array)
{
    foreach(string elem in array)
    {
        Console.Write($"{elem} ");
    }
}

PrintArray(sample);
Console.WriteLine();
string[] filteredArray = FilterArray(sample);
PrintArray(filteredArray);