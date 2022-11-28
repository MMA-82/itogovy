//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите длину массива: ");
int l = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Наполним массив элементами, введите любое слово или число!");
string[] array = new string[l];
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Элемент {i + 1}: ");
        array[i] = Console.ReadLine() ?? "0";
    }
}
FillArray(array);
Console.WriteLine();

Console.WriteLine("Получили массив: ");
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
PrintArray(array);
