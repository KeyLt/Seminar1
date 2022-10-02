int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thusrsday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday = 7;

Console.Write("Введите число ");
string Number = Console.ReadLine();
int numbers = Convert.ToInt32(Number);
 if ( numbers == Monday) Console.WriteLine("Monday");
 if ( numbers == Tuesday) Console.WriteLine("Tuesday");
 if ( numbers == Wednesday) Console.WriteLine("Wednesday");
 if ( numbers == Thusrsday) Console.WriteLine("Thusrsday");
 if ( numbers == Friday) Console.WriteLine("Friday");
 if ( numbers == Saturday) Console.WriteLine("Saturday");
 if ( numbers == Sunday) Console.WriteLine("Sunday");