//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Задайте длину массива: ");
int l = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Наполним массив элементами, введите любое слово или число!");
int m = 0;
string[] arr1 = new string[l];
void FillArray(string[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write($"Элемент {i + 1}: ");
        arr1[i] = Console.ReadLine() ?? "0";
        if (arr1[i].Length <= 3) m++;
    }
}
FillArray(arr1);
Console.WriteLine();

int j = 0;
string[] arr2 = new string[m];
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= 3)
    {
        arr2[j] = arr1[i];
        j++;
    }
}

Console.WriteLine("Отобрали в новый массив элементы, содержащие не более 3-х символов:");
void PrintArray(string[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"{arr2[i]} ");
    }
}
PrintArray(arr2);
