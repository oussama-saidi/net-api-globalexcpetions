namespace Net.WebApi.Globalexcpetions.Exceptions;

public class UnauthorizedAccessException : Exception
{
    public UnauthorizedAccessException(string message) : base(message)
    { }
}
