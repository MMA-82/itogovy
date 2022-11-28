//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите длину массива: ");
int l = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Наполним массив элементами, введите любое слово или число!");
string[] array1 = new string[l];
void FillArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"Элемент {i + 1}: ");
        array1[i] = Console.ReadLine() ?? "0";
    }
}
FillArray(array1);
Console.WriteLine();


string[] array2 = new string[array1.Length];
//int a2 = array2.Length;
void SortArray(string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
        int n = array1[i].Length;
        if(n <= 3) 
        {
            array2[i] = array1[i];
            //a2 = l - 1;
        }
    }
}
SortArray(array2);

Console.WriteLine("Получили массив: ");
void PrintArray(string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]}, ");
    }
}
PrintArray(array2);
