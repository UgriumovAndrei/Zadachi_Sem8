// Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

void PrintArray (string[,]array)
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
Console.WriteLine("Input row number");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [n+1,(n*2)+1];

array[0,n] = 1;
for(int i = 1; i<n; i++)
{
    for(int j  = 1; j<array.GetLength(1)-1;j++)
    {
            array[i,j] = array[i-1,j-1] + array[i-1, j+1];
    }
}
string [,] array2 = new string [array.GetLength(0), array.GetLength(1)];
for(int i = 0; i<array2.GetLength(0); i++)
{
    for(int j = 0; j<array2.GetLength(1); j++)
    {
        if(array[i,j]==0) array2[i,j] = " ";
        else array2[i,j] = Convert.ToString(array[i,j]);
    }
}
PrintArray(array2);