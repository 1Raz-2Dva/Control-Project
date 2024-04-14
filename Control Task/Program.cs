// Write a program that, from the array string, forms an array of strings whose length is less than or equal to 3 characters. 
// The initial array can be entered using the keyboard, or the start of the algorithm can be specified. 
// It is not recommended to use collections in the solution; it is better to use arrays exclusively.

Console.WriteLine ("Task condition Array is: Please could you stop the noise? i'm trying to get some rest from all the unborn chicken voices in my head");
string[] array1 = new string[] {"Please", "could", "you", "stop", "the", "noise?", "i'm", "trying", "to", "get", "some", "rest", "From", "all", "the", "unborn", "chicken", "voices", "in", "my", "head"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
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
SecondArrayWithIF(array1, array2);
Console.Write("Result array: ");
PrintArray(array2);