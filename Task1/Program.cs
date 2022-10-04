//По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите первое число ");
string First_number = Console.ReadLine();
int number_first = Convert.ToInt32(First_number);
Console.Write("Введите второе число ");
string Second_number = Console.ReadLine();
int number_second = Convert.ToInt32(Second_number);
int Numbers_Task = 0;
Numbers_Task = number_first / number_second;
if(Numbers_Task == number_second)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}
