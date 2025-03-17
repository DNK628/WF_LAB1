using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Розрахунок прибутку по банківському вкладі\n");

        // Введення суми вкладу
        Console.Write("Введіть суму вкладу: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal deposit) || deposit <= 0)
        {
            Console.WriteLine("Некоректна сума!");
            return;
        }

        // Введення терміну вкладу
        Console.Write("Введіть термін вкладу (1, 3, 6, 12 місяців): ");
        if (!int.TryParse(Console.ReadLine(), out int term) || (term != 1 && term != 3 && term != 6 && term != 12))
        {
            Console.WriteLine("Некоректний термін!");
            return;
        }

        // Визначення процентної ставки
        decimal rate = term switch
        {
            1 => 0.05m,
            3 => 0.06m,
            6 => 0.07m,
            12 => 0.10m,
            _ => 0m
        };

        // Розрахунок прибутку
        decimal profit = deposit * rate * term / 12;
        decimal totalAmount = deposit + profit;

        // Виведення результату
        Console.WriteLine($"\nСума вкладу: {deposit:C}");
        Console.WriteLine($"Процентна ставка: {rate * 100}%");
        Console.WriteLine($"Прибуток: {profit:C}");
        Console.WriteLine($"Загальна сума: {totalAmount:C}");
    }
}

