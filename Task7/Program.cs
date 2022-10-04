// Показать вторую цифру трехзначного числа
Console.Write("Введите трехзначное число ");
string s;
string result;
s = Console.ReadLine();
while(s.Length > 0 && s.Length < 4 && s.Length > 2) {
    // result = s.Substring(1, 1);
    // Console.WriteLine(result);
    Console.WriteLine(s[1]);
    return;
   }