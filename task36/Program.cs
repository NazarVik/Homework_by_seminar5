// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

const int SIZE = 10;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 100;

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
Console.Clear();
array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
int length = array.Length;
int sum = 0;
int count = 1;

while(count < length)
{
    sum += array[count];
    count += 2;
}
System.Console.WriteLine("[" + string.Join(",", array) + "] -> " + sum);