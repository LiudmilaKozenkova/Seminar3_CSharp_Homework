//int count = 5;
//int[] array = { 1, 4, 8, 4, 1 };
//int index = 0;
//Console.Write("Является ли палиндромом число = ");
//Console.Write(array);
//Console.WriteLine();

//1.Функция получения случайных чисел от мин до макс
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
    //int value = new Random().Next(1, 10);
    //return value;
}
//2.Метод создания нового массива
int[] CreateNewArray(int size)
{
    return new int[size];
    //int[]array = new int[size];
    //return array;
}
//3.Метод заполнения массива
void Fill(int[] array)
{
    int count = array.Length;
    int index = 0;

    while (index < count)
    {
        array[index] = GetIntValue(1, 10);
        index++;
    }
}
//4.Распечатать исходный массив
void Print(int[]array)
{
    int i =0;
    int size = array.Length;
    while(i<size)
    {
        Console.Write(array[i] + " ");
        i++;
    }
Console.WriteLine(); 
}
//5.Метод определения, является ли число палиндромом
void Palindrome (int[] array)
{
int[] source = CreateNewArray(5);
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
}

int[]collection = CreateNewArray(5);
Console.Write("Является ли палиндромом число = ");
Fill(collection);
Print(collection);
Palindrome(collection);
