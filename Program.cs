// // Написать программу, 
// которая из имеющегося массива строк 
// формирует массив из строк длина которых 
// меньше либо равна 3 символа.
string[] array = {"football", "soccer", "123", "12"};
// Console.WriteLine(array);
void ReadArray()
{   
    for (int i = 0; i < 4; i++)
    {
    // if (array[i] != null )
    // { 
        Console.Write($"{array[i]} ");
    // }
    }
Console.WriteLine();
}
ReadArray();