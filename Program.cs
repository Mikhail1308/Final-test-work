// Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа.


Console.WriteLine("Введите массив строк через запятую");
string[] array1;
string stroka = Console.ReadLine()!;
array1 = stroka!.Split(',');
string[] array2 = new string[array1.Length];

void SecondArrayCheck(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArrayCheck(array1, array2);
PrintArray(array2);
Console.WriteLine("Для завершения нажмите Enter");
Console.ReadKey(true);