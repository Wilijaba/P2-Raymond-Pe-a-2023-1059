using System;

public class Payroll
{
    private decimal CalculateNetSalary(decimal grossSalary)
    {
        decimal tax = grossSalary * 0.18m;
        decimal bonus = grossSalary * 0.05m;
        return grossSalary - tax + bonus;
    }

    public decimal CalculateSalaryForFullTime(decimal baseSalary)
    {
        return CalculateNetSalary(baseSalary);
    }

    public decimal CalculateSalaryForPartTime(decimal hourlyRate, int hoursWorked)
    {
        decimal salary = hourlyRate * hoursWorked;
        return CalculateNetSalary(salary);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Seleccione el tipo de empleado (1: Tiempo completo, 2: Medio tiempo): ");
        string employeeType = Console.ReadLine();

        Payroll payroll = new Payroll();
        decimal netSalary = 0;

        if (employeeType == "1")
        {
            Console.Write("Ingrese el salario base: ");
            decimal baseSalary = decimal.Parse(Console.ReadLine());
            netSalary = payroll.CalculateSalaryForFullTime(baseSalary);
        }
        else if (employeeType == "2")
        {
            Console.Write("Ingrese el sueldo por hora: ");
            decimal hourlyRate = decimal.Parse(Console.ReadLine());
            Console.Write("Ingrese las horas trabajadas: ");
            int hoursWorked = int.Parse(Console.ReadLine());
            netSalary = payroll.CalculateSalaryForPartTime(hourlyRate, hoursWorked);
        }
        else
        {
            Console.WriteLine("Tipo de empleado no válido.");
            return;
        }

        Console.WriteLine($"Salario neto después de impuestos y bono: {netSalary}");
    }
}