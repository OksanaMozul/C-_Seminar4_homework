// Урок 4. Функции

// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// intnumberA=ReadInt("Введите число A: ");
// intnumberB=ReadInt("Введите число B: ");
// Stepen(numberA, numberB);

// //возводим в степень
// voidStepen(inta, intb)
// {
//     intresult=1;
//     for(inti=1; i<=b; i++)
//     {
//         result=result*a;
//     }
//     Console.WriteLine(result);
// }

// intReadInt(stringmessage)
// {
//     Console.WriteLine(message);
//     returnConvert.ToInt32(Console.ReadLine());
// }

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// int number = ReadInt("Введите число: ");
// int len = NumberLen(number);
// SumNumbers(number, len);


// //  ввод
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // подсчет цифр в числе
// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// // вывод суммы цифр в числе
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

 int lenArray = ReadInt("Введите длинну массива: "); 

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}
// ввод
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
