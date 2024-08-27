namespace Dental_Clinic.ExceptionHandler.StatusCodeExceptions
{
    public class InternalServerErrorException : Exception
    {
        public InternalServerErrorException(string message) : base(message) { }
    }
}
