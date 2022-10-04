// показать четные числа от 1 до N
int First_number = 1;
Console.Write("Введите число ");
int Second_number = int.Parse(Console.ReadLine());
First_number = First_number + 1;

for(int i = First_number; i < Second_number; i = i + 2) {
    
    Console.WriteLine(i);
}



