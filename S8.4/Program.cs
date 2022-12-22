//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.
void PrintArray (int[,]array)
{
for(int i = 0; i<array.GetLength(0); i++)
{
    for(int j = 0; j<array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
}
Console.WriteLine("Сколько строк будет в Вашем массиве?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько столбцов будет в Вашем массиве?");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] array = new int [m,n];
int mini = 0;
int minj = 0;
for(int i = 0; i<array.GetLength(0); i++)
{
    for(int j = 0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random(). Next(1, 10); // работет и с2 и 3 значными, со всеми в общем числами
        Console.Write($"{array[i,j]} ");
        if(array[i,j]<array[mini,minj]) 
        {
            mini = i;
            minj = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
int [,] array2 = new int[m-1,n-1];
int i2 = 0;
int j2 = 0;
while(i2 < array2.GetLength(0))
{
    
    while(j2<array2.GetLength(1))
    {
        
        for(int i = 0; i<array.GetLength(0); i++)
        {
            j2 = 0;
            for(int j = 0; j<array.GetLength(1); j++)
            {
                if(i == mini || j == minj) i+=0;
                else
                {
                    array2[i2,j2] = array[i,j];
                    j2++;
                    if(j2==array2.GetLength(1)) i2++;
                }
            }
        
        }
    }
}

PrintArray(array2);