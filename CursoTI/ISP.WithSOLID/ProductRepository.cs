using System.Collections.Generic;

namespace ISP.WithSOLID
{
    public class ProductRepository : IReadable<Product>, IWriteable<Product>, IDeleteable
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
