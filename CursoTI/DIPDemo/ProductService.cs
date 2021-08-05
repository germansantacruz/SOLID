using DIPAbstractions;
using System;

namespace DIPDemo
{
    public class ProductService
    {
        readonly ILogger logger;

        public ProductService(ILogger _logger)
        {
            logger = _logger;
        }

        public void Create(Product product)
        {
            // ... crear producto

            var activity = new Activity
            {
                Message = $"Producto agregado..{product.Id}",
                Module = nameof(Create),
                CreatedDate = DateTime.Now
            };
            logger.Write(activity);
        }
    }
}
