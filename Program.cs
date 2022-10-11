// // Написать программу, 
// которая из имеющегося массива строк 
// формирует массив из строк длина которых 
// меньше либо равна 3 символа.
string[] array = {"football", "soc", "12", "124"};
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
string[] newArray = new string[array.Length];
void PrintArray()
{   int count = 0;
    for (int i = 0; i < 4; i++)
    {
    if (array[i].Length <= 3)
    {  
        newArray[count] = array[i];
        count++;
        Console.Write($"{array[i]} ");
    } 
    }
Console.WriteLine();
}
ReadArray();
PrintArray();