namespace Dental_Clinic.ExceptionHandler.StatusCodeExceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) { }
    }
}
