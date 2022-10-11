/* Напишите программу, которая принимает на вход (A) и выдает сумму чисел от 1 до A.

7 -> 28

4 -> 10

8 -> 36 */

// int FindSum (int toNumber){
//     int result = 0;
//     for (int i = 1; i <= toNumber; i++)
//     {
//         result+=i;
//     }   
//     return result;
// }

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма чисел от 1 до {n} = {FindSum(n)}");



// /* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5 */



// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Количество цифр в числе равно {CountNumber(number)}");

// int CountNumber(int number) {
//     int count = 0;
//     do {
//         number /= 10;
//         count++;
//     } while (number > 0);
//     return count;
// }


// int[] arr = new int[8];
// Console.WriteLine("Какое задание показать, 1 или 2?");
// int x = int.Parse(Console.ReadLine()!);
// if (x == 1) FirstQuestion();
// else SecondQuestion();





// /* Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120 */
// void FirstQuestion(){
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"-> {MultNumbers(number)}");
// }
// int MultNumbers (int number) {
//     int result = 1;
//     for (int i = 1; i <= number; i++) {
//         result *= i;
//     }
//     return result;
// }

// /* Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0] */
// void SecondQuestion(){ 
// FillArray(arr.Length);
// Console.Write("[");
// Console.Write(String.Join(" | ",arr));
// Console.WriteLine("]");
// }
// void FillArray (int size){
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(0,2);
//     }
// }


// ------------------------------------------------------------------------------------------------------------------------------------------------
// Домашнее задание

// Для изменения размера массива
int sizeArray = 8;

// Тело программы
int questionNumber = StartHW();
switch (questionNumber)
{
    case 1: DegreeNumber(); break;
    case 2: SumNumbers(); break;
    case 3: ViewArray(FillArray(sizeArray), "-"); break;
    
}

// Выбор задания для выполнения
int StartHW()
{
    int x;
    do
    {
        Console.Write("Введите номер задания (1, 2 или 3): ");
        x = int.Parse(Console.ReadLine()!);
        if (x < 1 || 3 < x) Console.WriteLine("Вы ввели некорректный номер.");
    } while (x < 1 || 3 < x);
    return x;
}


// Метод(ы) первого задания
void DegreeNumber()
{
    Console.Write("Введите число: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Введите искомую натуральную степень: ");
    int b = int.Parse(Console.ReadLine()!);
    Console.Write($"{a} в натуральнойстепени {b} равняется - {LogicForDegreeNumber(a, b)}");
}

int LogicForDegreeNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}


// Метод(ы) второго задания
// Можно очень легко решить это используя string, но я подумал что так нельзя :)
void SumNumbers()
{
    Console.Write("Введите число/цифру: ");
    int number = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Сумма чисел в цифре {number} равна - {LogicForSumNumbers(number)}");
}

int LogicForSumNumbers(int number)
{
    int result = 0;
    do
    {
        result += number % 10;
        number /= 10;
    } while (number > 0);
    return result;
}


// Метод(ы) третьего задания
int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

void ViewArray(int[] array, String separator)
{
    int size = array.Length;
    Console.Write("[");
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write($"{array[i]}{separator}");
    }
    Console.Write($"{array[size - 1]}]");
}