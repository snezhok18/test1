// Задача: 
// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

string[] myArray = new string[3];
int j = 0;
int count = 0;

Console.WriteLine("Введите несколько символов: ");
myArray[0] = Console.ReadLine()!;
Console.WriteLine("Введите несколько символов: ");
myArray[1] = Console.ReadLine()!;
Console.WriteLine("Введите несколько символов: ");
myArray[2] = Console.ReadLine()!;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length < 4)
    {
        count += 1;
    }
}
string[] newArray = new string[count];

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length < 4)
    {
        newArray[j] = myArray[i];
        j++;
    }
}
Console.WriteLine();

if (count == 0)
{
    Print(myArray);
    Console.WriteLine(" - > []");
}
else
{
    Print(myArray);
    Console.WriteLine(" - >");
    Print(newArray);
}

// ----------
void Print(string[] array)
{
    foreach (var i in array)
    {
        Console.Write("[{0}] ", i);
    }
}