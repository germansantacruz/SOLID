namespace OCPDemo
{
    public class LogService
    {
        // Rompe el principio de OCP porque si queremos agregar un nuevo tipo de registro al Log
        // como por ejemplo eventos de Windows debemos modificar el código
        public void Write(Activity activity, string target)
        {
            switch (target)
            {
                case "console":
                    WriteToConsole(activity);
                    break;
                case "file":
                    WriteToFile(activity);
                    break;            
            }
        }

        void WriteToConsole(Activity activity)
        { 
        }

        void WriteToFile(Activity activity)
        { 
        }
    }
}
