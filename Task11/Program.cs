// найти третью цифру числа или сообщить, что ее нет
Console.Write("Введите трехзначное число ");
string s = Console.ReadLine();
if(s.Length > 0 && s.Length < 4 && s.Length > 2)
    Console.WriteLine(s[2]);
if(s.Length > 0 && s.Length < 3)
    Console.WriteLine("третьей цифры нет");
if(s.Length > 0 && s.Length > 3)
    Console.WriteLine("в числе больше трех символов");
return;
   
