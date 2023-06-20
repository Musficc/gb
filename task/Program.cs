string[] stringArray = new string[] { "Pr0", "1230", "J'aime le lasan", "Зонтик", "d@m", ",..,", "ga", "123456987", "raj", ":)" };
string[] resultArray = new string[0];

void outputArray(string[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        System.Console.Write($"{inputArray[i]} | ");
    }
    System.Console.WriteLine("\n");
}

string[] findStringThreeChars(string[] inputArray)
{
    string[] resultArray = new string[0];
    int j;
    for (int i = 0; i < inputArray.Length; i++)
    {
        j = 0;
        while (j < inputArray[i].Length)
        {
            j++;
        }
        if (j <= 3)
        {
            Array.Resize(ref resultArray, resultArray.Length + 1);
            resultArray[resultArray.Length - 1] = inputArray[i];
        }
    }
    return resultArray;
}

System.Console.WriteLine("\nЗадан массив строк:");
outputArray(stringArray);

resultArray = findStringThreeChars(stringArray);
System.Console.WriteLine("Его элементы, у которых три и меньше символов:");
outputArray(resultArray);