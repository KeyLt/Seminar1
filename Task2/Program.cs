// int Monday = 1;
// int Tuesday = 2;
// int Wednesday = 3;
// int Thursday = 4;
// int Friday = 5;
// int Saturday = 6;
// int Sunday = 7;

// Console.Write("Введите число ");
// string Number = Console.ReadLine();
// int numbers = Convert.ToInt32(Number);
//  if ( numbers == Monday) Console.WriteLine("Monday");
//  if ( numbers == Tuesday) Console.WriteLine("Tuesday");
//  if ( numbers == Wednesday) Console.WriteLine("Wednesday");
//  if ( numbers == Thursday) Console.WriteLine("Thursday");
//  if ( numbers == Friday) Console.WriteLine("Friday");
//  if ( numbers == Saturday) Console.WriteLine("Saturday");
//  if ( numbers == Sunday) Console.WriteLine("Sunday");
//  else Console.WriteLine("There is no such day");


Console.Write("Введите число ");
int numbers = Convert.ToInt32(Console.ReadLine());
switch(numbers){
    case (1): 
        Console.WriteLine("Monday"); 
        break;
    case (2): 
        Console.WriteLine("Tuesday"); 
        break;
    case (3): 
        Console.WriteLine("Wendnesday"); 
        break;
    case (4): 
        Console.WriteLine("Thusday"); 
        break;
    case (5): 
        Console.WriteLine("Friday"); 
        break;
    case (6): 
        Console.WriteLine("Saturday"); 
        break;
    case (7): 
        Console.WriteLine("Sunday"); 
        break;
    default:
        Console.WriteLine("There is no such day");
        break;
}
