namespace LSP.WithSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            // El código cumple con el principio de Liskov porque sus subclases
            // mantienen sus comportamientos de forma similar
            ICreatable c = new Product();
            c.Create();         // ok

            (c as IUpdateable).Update();

            c = new Category();
            c.Create();         // ok
        }
    }
}
