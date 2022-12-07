// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

const int SIZE = 10;

double[] array = new double[SIZE];

double[] FillArrayWithRandomNumbers(int size)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for( int i = 0 ; i < size; i++)
    { 
        arr[i] = rand.Next(100) + Math.Round(rand.NextDouble(), 2); 
    }
    return arr;
}

int MinPos(double[] arr)
{
    int minPos = 0;
    for (int i = 1; i < arr.Length; i++)
    {        
        if(arr[i] < arr[minPos])
        {
            minPos = i;
        }        
    }
    return minPos;
}

int MaxPos(double[] arr)
{
    int maxPos = 0;
    for (int i = 1; i < arr.Length; i++)
    {        
        if(arr[i] > arr[maxPos])
        {
            maxPos = i;
        }        
    }
    return maxPos;
}

Console.Clear();
array = FillArrayWithRandomNumbers(SIZE);
double minNum = array[MinPos(array)];
double maxNum = array[MaxPos(array)];
double differ = maxNum - minNum;

System.Console.WriteLine("[" + string.Join("  ", array) + "] -> " + differ );
