//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите 1-e число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-e число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());
int maxim = 0;
if(a>b && a > c){
    maxim = a;
}
else{
    if (b>c){
        maxim = b;
    }
    else{
        maxim = c;
    }
}
Console.Write("Самое большое: ");
    Console.Write(maxim);