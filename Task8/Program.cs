Console.Write("Введите двухзначное число ");
string s;
s = Console.ReadLine();
while(s.Length > 0 && s.Length < 3 && s.Length > 1){
    if (s[0] > s[1]) Console.WriteLine(s[0]);
    if (s[0] < s[1]) Console.WriteLine(s[1]);
    if (s[0] == s[1]) Console.WriteLine("Числа рaвны");
return;
}