using System;

namespace SRP.WithSOLID
{
    public class LogService : ILog
    {
        public void Write(Activity activity)
        {
            // codigo para registrar la actividad
            Console.WriteLine("{0}, {1}, {2}", activity.CreatedDate, activity.Module,
                activity.Message);
        }
    }
}
