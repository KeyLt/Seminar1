//Выяснить, кратно ли число заданному, если нет вывести остаток

Console.Write("Введите первое число ");
double s = double.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
double k = double.Parse(Console.ReadLine());

if (s % k == 0) Console.WriteLine("Кратно");

else{
double p = s % k;
 Console.WriteLine(p);
}
