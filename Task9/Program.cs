// Удалить вторую цифру трехзначного цисла
Console.Write("Введите трехзначное число ");
int s = int.Parse(Console.ReadLine());
while(s > 99 && s < 1000)
{
    int j;
    j = s / 100 * 10 + s%10;
    Console.WriteLine(j);

return;
}