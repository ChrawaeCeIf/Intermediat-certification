string[] CreateNewArray(string[] array)
{
    int size = 0;
    int index = 0;
    while(index < array.Length)
    {
        if(array[index].Length <= 3)
        {
            size++;
            index++;
        }
        else
            index++;
    }
    string[] NewArray = new string[size];
    return NewArray;
}

string[] FillNewArray(string[] firstArray, string[] secondArray)
{
    int firstIndex = 0;
    int secondIndex = 0;
    while(firstIndex < firstArray.Length)
    {
        if(firstArray[firstIndex].Length <= 3)
        {
            secondArray[secondIndex] = firstArray[firstIndex];
            firstIndex++;
            secondIndex++;
        }
        else
            firstIndex++;
    }
    return secondArray;
}



void PrintArray(string[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

string[] firstArray = {"fwe534","ff","w5","3534","fs","z534x","twt","qeq"};
string[] secondArray = CreateNewArray(firstArray);
string[] resArray = FillNewArray(firstArray, secondArray);
PrintArray(firstArray);
PrintArray(resArray);
