using System;

namespace SRPDemo
{
    // Esta clase no cumple con el principio SRP, tiene 2 responsabilidades
    // Crear el producto y registrar el log
    class ProductsService
    {
        public void Create(Product product)
        {
            // codigo para crear el producto ...
            // Registrar la actividad ...

            var activity = new Activity()
            {
                Message = $"Producto agregado {product.Id}",
                Module = nameof(Create),
                CreatedDate = DateTime.Now
            };
            WriteLog(activity);
        }

        public void WriteLog(Activity activity)
        {
            // codigo para registrar la actividad
            Console.WriteLine("{0}, {1}, {2}", activity.CreatedDate, activity.Module,
                activity.Message);
        }
    }
}