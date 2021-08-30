using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Business
{
    public class ProductBusiness
    {
        public void AddProduct(Product product)
        {
            if (product.Name == null || product.Name == "")
                throw new Exception("El nombre del producto es obligatorio.");

            if (product.UnitPrice < 0)
                throw new Exception("El precio unitario no puede ser negativo.");

            if (product.UnitsInStock < 0)
                throw new Exception("La cantidad de unidades en stock no puede ser negativa.");

            var productDataAccess = new ProductDataAccess();
            productDataAccess.AddProduct(product);
        }
    }
}
