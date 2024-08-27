namespace Dental_Clinic.ExceptionHandler.StatusCodeExceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }
}
