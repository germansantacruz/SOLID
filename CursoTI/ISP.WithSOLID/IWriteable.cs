namespace ISP.WithSOLID
{
    public interface IWriteable<T>
    {
        void Create(T entity);      
        void Update(T entity);
    }
}
