/*
Задача: написать программу, которая из имеющегося массива строк формирует массив из строк,
длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer scince"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] userArray = { "hello", "2", "world", ":-)" };

void PrintArray(string[] userArray) // Функция вывода массива.
{
    for (int i = 0; i < userArray.Length; i++)
    {
        if (i == 0) Console.Write($"[{userArray[i]}, ");
        else if (i == userArray.Length - 1) Console.Write($" {userArray[i]}]");
        else Console.Write($"{userArray[i]}, ");
    }
}


string[] ThreeSimbol(string[] array) //Функция, возвращающая элементы массива длинной меньше или равной 3 символам.
{
    string[] threeSimbol = new string[array.Length]; //Создаем массив длиной равной длине принимаемого аргумента.
    for (int i = 0, j = 0; i < array.Length; i++)   //Циклически перебираем от 0 до последнего элемента принимаемого аргумента.
    {
        if (array[i].Length <= 3)                   //если длина i-го элемента меньше или равна 3.
        {
            threeSimbol[j] = array[i];        //Элемент второго массива равен элементу первого.
            j++;                                  //Увеличиваем индекс второго массива на единицу.   
        }
        else
        {
            Array.Resize(ref threeSimbol, threeSimbol.Length - 1);  //Иначе уменьшаем длину второго массива на 1. 
        }
    }
    return threeSimbol;
}
PrintArray(userArray);
Console.Write($" -> ");
string[] threeSimbol = ThreeSimbol(userArray);
PrintArray(threeSimbol);