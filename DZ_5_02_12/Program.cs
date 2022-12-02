void Zadacha34()
{
    //Задача 34: Задайте массив заполненный случайными 
    //положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
    int size = 4;
    int [] number = new int[size];
    Console.WriteLine("Добрый день. Рады приветсвовать!");
    FillArray(number, 100, 1000 );
    PrintArray(number);
    int sum = 0;
    for ( int i=0; i < size; i++)
    {
        if (number[i] % 2==0 )
        {
            sum++;
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine("Четных чисел в массиве  "+ sum);
}

void Zadacha36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    //Найдите сумму элементов с нечётными индексами.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0
    int size = 4;
    int [] number = new int[size];
    Console.WriteLine("Добрый день. Рады приветсвовать!");
    FillArray(number, -10, 100 );
    PrintArray(number);
    int sum = 0;
    for ( int i=0; i < size; i++)
    {
        if (i % 2 !=0 )
        {
            sum = sum + number[i];
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine("Сумма элементов с нечетными индексами "+ sum);
}

void Zadacha38()
{
    //Задача 38: Задайте массив вещественных чисел. 
    //Найдите разницу между максимальным и минимальным элементов массива.
    //[3,21 7,04 22,93 -2,71 78,24] -> 80,95
    int size = 4;
    double [] number = new double [size];
    Console.WriteLine("Добрый день. Рады приветсвовать!");
    
    Random rand = new Random();
    for (int i=0; i < size; i++) 
    {
        number [i] = Convert.ToDouble(rand.Next (-10, 100)) / 100;
    }
   
    Console.WriteLine("  ");
    Console.WriteLine("Вывод массива:");
    for (int i=0; i < size; i++) 
    {
        Console.Write(number[i]+"  ");
    }
    Console.WriteLine();
    Console.WriteLine();
    
    //Отсюда не знаю, как решить 
    double max = number[0];
    double min = number[0];
    
    for (int i = 0; i < size; i++)
    {
        if(number[i]>max)
        {
            number[i]=max;
        }
        if(number[i]<min)
        {
            number[i]=min;
        }
    }
    Console.WriteLine ("Максимальное число "+ Math.Round(max,2));
    Console.WriteLine ("Минимальное число "+ Math.Round(min,2));
    Console.WriteLine ($"Разница между макс и мин числом = {max-min}");
}
void PrintArray(int[] nums)
{
    int length = nums.Length;
    Console.WriteLine("Вывод массива:");
    for (int i=0; i < length; i++) 
    {
        Console.Write(nums[i]+"  ");
    }
    Console.WriteLine();
    Console.WriteLine();

}

void FillArray(int [] nums, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();//создаем рандом rand
    int length = nums.Length;//размер делаем
    for (int i=0; i < length; i++) //создаем цикл
    {
        nums [i] = rand.Next (minValue,maxValue);       //обращаемся к массиву и задаем ему значения 
    }


}

//Zadacha34();
//Zadacha36();
Zadacha38();