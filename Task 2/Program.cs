// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите длинну массива - ");
int ArrayLenghts = int.Parse(Console.ReadLine()!);

int[] array = GetArray(ArrayLenghts, 1, 10);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

void GetSumm(int[] arr)
{
    int Summ = 0;
        for (int i = 0; i < ArrayLenghts; i++)
        {
            if (i%2 > 0)
            {
                
            }
            else
            {
            Summ += arr[i];
            }
        }
        
    
Console.Write($"Сумма чисел, стоящих на нечётных позициях = {Summ}");
}
GetSumm(array);
