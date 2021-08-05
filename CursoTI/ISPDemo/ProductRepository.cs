using System.Collections.Generic;

namespace ISPDemo
{
    public class ProductRepository : IRepository<Product>
    {
        public void Create(Product entity)
        {
            // cógido
        }

        public void Delete(int id)
        {
            // cógido
        }

        public IEnumerable<Product> RetrieveAll()
        {
            // ...
            return new List<Product>();
        }

        public Product RetrieveById(int id)
        {
            // cógido
            return new Product();
        }

        public void Update(Product entity)
        {
            // cógido
        }
    }
}
