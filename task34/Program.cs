// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

const int SIZE = 10;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 1000;

int[] array = new int[SIZE];

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for( int i = 0 ; i<size; i++)
    { 
        arr[i] = rand.Next(leftRange, rightRange); 
    }
    return arr;
}

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);

int length = array.Length;
int count = 0;
for (int i = 0; i < length; i++)
{
    if(array[i] % 2 ==0)
    {
        count ++;
    }
    
}

System.Console.WriteLine("[" + string.Join(",", array) + "] -> " + count);