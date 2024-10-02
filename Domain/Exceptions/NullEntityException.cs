namespace Domain.Exceptions;

public class NullEntityException : Exception
{
    public NullEntityException(string message, Exception inner) : base(message, inner)
    { }
    
    public NullEntityException(string message = "can't find entity by given id") : base(message)
    { }
}