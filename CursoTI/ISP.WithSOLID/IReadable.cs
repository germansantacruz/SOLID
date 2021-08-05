using System.Collections.Generic;

namespace ISP.WithSOLID
{
    public interface IReadable<T>
    {        
        T RetrieveById(int id);
        IEnumerable<T> RetrieveAll();        
    }
}
