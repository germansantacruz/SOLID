namespace OCP.WithSOLID
{
    // Esta clase cumple con OCP, no necesita ser modificada si se agregan nuevas formas
    // de registrar actividades
    public class LogService
    {
        readonly ILogger logger;

        public LogService(ILogger _logger)
        {
            logger = _logger;
        }

        public void Write(Activity activity)
        {
            logger.Write(activity);
        }
    }
}
