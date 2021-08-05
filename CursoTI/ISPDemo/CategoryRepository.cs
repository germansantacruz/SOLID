using System;
using System.Collections.Generic;

namespace ISPDemo
{
    public class CategoryRepository : IRepository<Category>
    {
        // Esta clase viola el principio ISP porque obliga a implementar
        // funcionalidad que no necesitamos implementar
        public void Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> RetrieveAll()
        {
            // ...
            return new List<Category>();
        }

        public Category RetrieveById(int id)
        {
            // ...
            return new Category();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
