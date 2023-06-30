/*
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум 
этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры
[“Hello”, “2”, “world”, “-)”] → [“2”, “-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


void PrintStringArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

string [] CreateNewArray (string[]array)
{
    string [] newArray = new string [3];
    int count = 0;
    for (int i = 0; i<newArray.Length; i++)
    {
        newArray[i] = array[i = new Random().Next(0,8)];
        count++;
        if (count == new Random().Next(0,4))
            break;
    }
    return newArray;
}



string [] array = { "Hello", "2", "world", "-)", "1234", "1567", "-2", "computer science" };
PrintStringArray(array);
string [] earray = CreateNewArray (array);
PrintStringArray(earray);