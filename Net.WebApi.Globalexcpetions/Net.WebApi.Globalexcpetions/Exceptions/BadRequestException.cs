namespace Net.WebApi.Globalexcpetions.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    { }
}
