using System.Collections.Generic;

namespace ISP.WithSOLID
{
    public class CategoryRepository : IReadable<Category>
    {
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
    }
}
