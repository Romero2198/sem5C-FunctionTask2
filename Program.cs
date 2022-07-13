int[] numbers = new int [4];
int count = 0;
FillArray(numbers);
PrintArray(numbers);

for(int i = 1; i < numbers.Length; i = i + 2)
{
    count = numbers[i] + count;
}
Console.WriteLine($"-> {count}");



void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 100);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}