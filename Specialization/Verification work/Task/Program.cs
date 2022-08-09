// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами

Console.Clear();
Console.WriteLine("Создание массива строк!");
Console.Write("Задайте количество элементов массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

string[] CreatArrayStr(int lengthArray)
{
    string[] arrayStr = new string[lengthArray];
    for (int i = 0; i < arrayStr.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        arrayStr[i] = Console.ReadLine();
    }
    return arrayStr;
}

void PrintArrayStr(string[] arrayStr)
{
    Console.WriteLine();
    Console.WriteLine("из [заданого массива] -> [создан массив] из строк не более 3-х символов:");
    for (int i = 0; i < arrayStr.Length; i++)
    {
        if (i == 0) Console.Write("[ ");
        if (i < arrayStr.Length-1) Console.Write($"'{arrayStr[i]}' " );
        else Console.Write($"'{arrayStr[i]}']");
    }
}

void ChecThreeCharacters (string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i == 0) Console.Write(" -> [ ");
        if (newArray[i].Length <= 3) Console.Write($"'{newArray[i]}' ");
        if (i == newArray.Length-1) Console.Write("]");
    }
}

string[] createNewArrayStr = CreatArrayStr(lengthArray);

PrintArrayStr(createNewArrayStr);
ChecThreeCharacters(createNewArrayStr);