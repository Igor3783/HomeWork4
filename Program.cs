//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int num =2;

if (number>1){
    while(num <= number){
        Console.Write(num + " ");
        num=num+2;
    }

}