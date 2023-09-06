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


void PrintStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        if (i == array.Length - 1)
            Console.Write(array[i]);
        else
            Console.Write(array[i] + ", ");
    Console.WriteLine();
}

string[] CreateNewArray(string[] array)
{
    int size = new Random().Next(1, 4);
    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        int k = 0;
        newArray[i] = array[k = new Random().Next(0,8)];
    }
    return newArray;
}



Console.WriteLine("имеется массив из строк: ");
string[] array = { "Hello", "2", "world", "-)", "1234", "1567", "-2", "computer science" };
PrintStringArray(array);
Console.WriteLine("из которого был сгенирирован новый массив не превышающий трёх символов: ");
string[] earray = CreateNewArray(array);
PrintStringArray(earray);