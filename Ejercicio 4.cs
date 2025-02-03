using System;

public interface INotification
{
    void Send(string message);
}

public class EmailNotification : INotification
{
    private string email;

    public EmailNotification(string email)
    {
        this.email = email;
    }

    public void Send(string message)
    {
        Console.WriteLine($"Enviando Email a {email}: {message}");
    }
}

public class SMSNotification : INotification
{
    private string phoneNumber;

    public SMSNotification(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public void Send(string message)
    {
        Console.WriteLine($"Enviando SMS a {phoneNumber}: {message}");
    }
}

public class NotificationLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Registrando notificación: {message}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el tipo de notificación:");
        Console.WriteLine("1. Email");
        Console.WriteLine("2. SMS");
        string option = Console.ReadLine();

        Console.Write("Ingrese el mensaje: ");
        string message = Console.ReadLine();

        INotification notification = null;

        if (option == "1")
        {
            Console.Write("Ingrese el correo electrónico: ");
            string email = Console.ReadLine();
            notification = new EmailNotification(email);
        }
        else if (option == "2")
        {
            Console.Write("Ingrese el número de teléfono: ");
            string phoneNumber = Console.ReadLine();
            notification = new SMSNotification(phoneNumber);
        }
        else
        {
            Console.WriteLine("Opción no válida.");
            return;
        }

        notification.Send(message);

        NotificationLogger logger = new NotificationLogger();
        logger.Log(message);
    }
}