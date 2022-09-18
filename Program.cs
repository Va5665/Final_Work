
 Console.Write(" Ввведите массив из 5 значений ");

string [] array1 = new string[5];
for(int i = 0;i<array1.Length;i++)
{
    array1[i]= Console.ReadLine();
}

string[] array2 = new string[array1.Length];

void Task(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
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
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
 Task(array1, array2);
 Console.Write("Mассив из строк, длина которых меньше, либо равна 3 символам = ");
PrintArray(array2);
