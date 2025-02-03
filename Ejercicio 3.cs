using System;

public class ProductService
{
    public void AddProduct(string name, decimal price)
    {
        Console.WriteLine($"Producto '{name}' agregado con precio {price}.");
    }

    public void DeleteProduct(int productId)
    {
        Console.WriteLine($"Producto con ID {productId} eliminado.");
    }
}

class Program
{
    static void Main()
    {
        ProductService productService = new ProductService();

        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Salir");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Ingrese el nombre del producto: ");
                string name = Console.ReadLine();
                Console.Write("Ingrese el precio: ");
                decimal price = decimal.Parse(Console.ReadLine());
                productService.AddProduct(name, price);
            }
            else if (option == "2")
            {
                Console.Write("Ingrese el ID del producto a eliminar: ");
                int productId = int.Parse(Console.ReadLine());
                productService.DeleteProduct(productId);
            }
            else if (option == "3")
            {
                break; // Salir del bucle
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }
        }
    }
}