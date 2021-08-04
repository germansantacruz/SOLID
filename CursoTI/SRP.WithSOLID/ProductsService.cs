using System;

namespace SRP.WithSOLID
{
    // Esta clase cumple con el principio SRP solo tiene una responsabilidad
    // Crear el producto y la funcionalidad de logging lo delega al servicio LogService
    public class ProductsService
    {
        readonly ILog logService;

        public ProductsService(LogService _logService)
        {
            this.logService = _logService;
        }

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

            logService.Write(activity);
        }
    }
}
