
int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

int[] InputArray(int length)
{
    int []array = new int[length];
    for (int i=0 ; i<array.Length; i++)
    {
        array[i] = Prompt($" input {i+1}");
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.WriteLine($" ([{i}] = {array[i]}");
    }
}
int CountNamber(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0)
        {
           count++; 
        } 
    }
    return count;
}
int length= Prompt($" input element ");
int [] array;
array=InputArray(length);
PrintArray(array);
Console.WriteLine($" {CountNamber(array)}");