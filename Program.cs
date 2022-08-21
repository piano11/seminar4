// Напишите цикл, который принимает на вход дваа числа (А и В)и возводит
//число А в натуральную степень В
/* 
 Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
 

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int power = 1;
int result = numberA;
while (power < numberB)

{
  result = result * numberA;
  
  power++;  

}

Console.WriteLine("Число " + numberA + " в сепени " + numberB + " равно " + result);

*/

// Напишите программу, котрая принимает на вход число и выдает сумму цифр в числе
/*
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigital = 0;

while (number > 0)
{
 int lastDigit = number % 10;
 sumDigital = sumDigital + lastDigit;
 number /=10;
}

  Console.WriteLine (sumDigital);
*/


// Напишите программу, которая задает массив из 8 элементов и выводит его на экран. 
/*
int [] array = new int [8];
Console.Write("[");

for (int i = 0; i< array.Length; i++)
{
  array[i] = new Random().Next(9);
  Console.Write(" " + array[i]);
}

Console.Write("]");
*/
