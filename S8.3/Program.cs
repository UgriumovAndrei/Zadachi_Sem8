// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Console.WriteLine("Сколько строк будет в Вашем массиве?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько столбцов будет в Вашем массиве?");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] array = new int [m,n];
for(int i = 0; i<array.GetLength(0); i++)
{
    for(int j = 0; j<array.GetLength(1); j++)
    {
        array[i,j] = new Random(). Next(1, 10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
int find;
for(int i1 = 0; i1<array.GetLength(0); i1++)
{
    for(int j1 = 0; j1<array.GetLength(1); j1++)
    {
        int count = 0;
        find = array[i1,j1];
        if(find>0)
        {
            for(int i = 0; i<array.GetLength(0); i++)
            {
                for(int j = 0; j<array.GetLength(1); j++)
                {
                    if(array[i,j] == find)
                    {
                        count++;
                        array[i,j] = -array[i,j];
                    }
                }
            }
        Console.WriteLine($"элемент {find} встречается {count} раз");
        }

    }
     
}