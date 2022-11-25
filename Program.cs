string[] array1 = new string[6] { "hello", "777", "33", "paint", "qwerty", "Z" };
string[] array2 = new string[array1.Length];
void Array(string[] array1, string[] array2)
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
Array(array1, array2);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
PrintArray(array2);