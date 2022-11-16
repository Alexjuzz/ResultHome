// Result homework


string[] arrayStr = { "Hello", "World", "2", ":-)" };
string[] arrayStr2 = { "1234", "1567", "-2", "Computer sience" };
string[] arrayStr3 = { "Russia", "Denmark", "Kazan" };

string[] createArray(string[] array, int count)  // Создание нового массива
{
    string[] resultArray = new string[count];

    int k = 0;
    foreach (var item in array)
    {
        if (item.Length <= 3)
        {
            resultArray[k] = item;
            k++;
        }
    }
    return resultArray;
}

int countValues(string[] array) // Подсчет строк размером <=3 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <=3){
            count++;
        }
    }
   
    return count;
}

void printArr(string[] array) // Печать массива
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }

}


printArr(createArray(arrayStr3,countValues(arrayStr3))); 