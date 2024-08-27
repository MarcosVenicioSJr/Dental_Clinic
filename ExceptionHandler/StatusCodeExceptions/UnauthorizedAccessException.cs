namespace Dental_Clinic.ExceptionHandler.StatusCodeExceptions
{
    public class UnauthorizedAccessException : Exception
    {
        public UnauthorizedAccessException(string message) : base(message) { }
    }
}
