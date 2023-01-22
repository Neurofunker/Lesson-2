/*12. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/
int MultipleNums(int num1, int num2)
{
    return num1 % num2;
}
Console.Write("введите целое число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите целое число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remains = MultipleNums(number1, number2);

if (remains == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Остаток от деления составляет {remains}");
}
