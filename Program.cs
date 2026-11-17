using System;

class Program
{

    public static int Add(int a, int b)
    {
        return a + b;
    }

    private static double Dev(double a, double b)
    {
        return a / b;
    }

    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Сумма: " + Add(a, b));

        if (b != 0)
        {
            Console.WriteLine("Частное: " + Dev(a, b));
        }
        else
        {
            Console.WriteLine("На ноль делить нельзя!");
        }
        User user = new User();

        user.Id = 1;
        user.Name = "Руслан";
        user.Login = "ruslan123";
        user.Email = "ruslan@mail.ru";
        user.Age = 18;

        Console.WriteLine("\nИнформация о пользователе:");
        Console.WriteLine("ID: " + user.Id);
        Console.WriteLine("Имя: " + user.Name);
        Console.WriteLine("Логин: " + user.Login);
        Console.WriteLine("Email: " + user.Email);
        Console.WriteLine("Возраст: " + user.Age);
    }
}
class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}