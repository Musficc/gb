string[] stringArray = new string[] { "Pr0", "1230", "J'aime le lasan", "Зонтик", "d@m", ",..,", "ga", "123456987", "raj" };
string[] resultArray = new string[0];

void outputArray(string[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        System.Console.Write($"{inputArray[i]} | ");
    }
    System.Console.WriteLine("\n");
}

void findStringThreeChars(string[] inputArray)
{
    string[] resultArray = new string[0];
    for (int i = 0; i < inputArray.Length; i++)
    {
        
    }
}

System.Console.WriteLine("\nЗадан массив:");
outputArray(stringArray);