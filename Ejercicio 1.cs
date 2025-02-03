using System;

public class RestaurantBill
{
    public decimal CalculateTotal(decimal[] prices, decimal tipPercentage)
    {
        decimal total = 0;

        // Sumar los precios de los platos
        foreach (var price in prices)
        {
            total += price;
        }

        // Calcular la propina
        total += total * (tipPercentage / 100);

        return total;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese los precios de los platos (separados por comas): ");
        string input = Console.ReadLine();
        decimal[] prices = Array.ConvertAll(input.Split(','), decimal.Parse);

        Console.Write("¿Desea agregar una propina personalizada? (s/n): ");
        string tipChoice = Console.ReadLine();
        decimal tipPercentage = 10; // Propina por defecto del 10%

        if (tipChoice.ToLower() == "s")
        {
            Console.Write("Ingrese el porcentaje de propina: ");
            tipPercentage = decimal.Parse(Console.ReadLine());
        }

        RestaurantBill bill = new RestaurantBill();
        decimal total = bill.CalculateTotal(prices, tipPercentage);

        Console.WriteLine($"Total a pagar (con propina del {tipPercentage}%): {total}");
    }
}