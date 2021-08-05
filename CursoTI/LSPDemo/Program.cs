using System;

namespace LSPDemo
{
    class Program
    {        
        static void Main(string[] args)
        {
            // No cumple con el principio de Liskov porque no mantiene el mismo
            // comportamiento para ambas subclases en el método Update
            Entity e = new Product();
            e.Create();
            e.Update();         // Ok
            e.Delete();

            e = new Category();
            e.Create();
            e.Update();         // Not ImplementedException

            Console.ReadLine();
        }
    }
}
