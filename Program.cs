// // Написать программу, 
// которая из имеющегося массива строк 
// формирует массив из строк длина которых 
// меньше либо равна 3 символа.
string[] array = {"football", "yep", "1256", "125"};
string[] newArray = new string[array.Length];
void ReadArray()
{   
    for (int i = 0; i < 4; i++)
    {

        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}
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