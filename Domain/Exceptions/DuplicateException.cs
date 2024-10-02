namespace Domain.Exceptions;

public class DuplicateException : Exception
{
    public DuplicateException(string message, Exception inner) : base(message, inner)
    { }
    
    public DuplicateException(string message) : base(message)
    { }
}
