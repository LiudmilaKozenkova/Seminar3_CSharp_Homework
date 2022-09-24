int count = 5;
int[] array = { 1, 2, 8, 2, 1 };
int index = 0;
Console.Write("Является ли палиндромом число = ");
Console.Write(array);

while (index < count)
{
    array[index] = new Random().Next(1, 10);
    Console.Write(array[index] + " ");
    index++;
}
index = 0;
if (array[0] == array[4])
{
    if (array[1] == array[3])
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}
else
{
    Console.WriteLine("НЕТ");
}