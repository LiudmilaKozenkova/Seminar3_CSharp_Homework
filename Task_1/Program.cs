int count = 5;
int[]array = new int[5];
int index = 0;

while(index<count)
{
    array[index] = new Random().Next(1, 10);
    Console.Write(array[index] + " ");
    index ++;
}
index = 0;
if(array[0]==array[3])
    {if(array[1]==array[4])
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