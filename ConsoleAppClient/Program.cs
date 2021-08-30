using Business;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.Write("Ingrese el nombre del producto: ");
            product.Name = Console.ReadLine();

            Console.Write("Ingrese la descripcion del producto: ");
            product.Description = Console.ReadLine();

            Console.Write("Ingrese el precio unitario del producto: ");
            product.UnitPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de unidades en stock: ");
            product.UnitsInStock = int.Parse(Console.ReadLine());

            Console.Write("¿El producto está discontinuado? s/n: ");
            product.Discontinued = (Console.ReadLine().ToLower() == "s")? true : false;

            Console.Write("Ingrese el ID de la categoría del producto: ");
            product.CategoryId = int.Parse(Console.ReadLine());

            ProductBusiness productBusiness = new ProductBusiness();
            productBusiness.AddProduct(product);

            Console.WriteLine("El producto fue agregado correctamente.");
        }
    }
}
