// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

void ThreeOrLessSymbolString(string[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        string value = massiv[i];
        if (value.Length <= 3)
        {
            Console.Write(massiv[i] + " ");
        }
        else Console.WriteLine("There are more than 3 symbols.");
    }
}

string[] array = { "Hello", "1", "two", ":-)", "Kazan", "Denmark", "123" };
ThreeOrLessSymbolString(array);