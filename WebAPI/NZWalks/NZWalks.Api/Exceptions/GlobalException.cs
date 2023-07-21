namespace NZWalks.Api.Exceptions;

public class GlobalException
{
    public class BadRequestException : Exception 
    {
        public BadRequestException(string msg) : base(msg) 
        { }
    }
    public class KeyNotFoundException : Exception
    {
        public KeyNotFoundException(string msg) : base(msg)
        { }
    }
    public class NotFoundException : Exception
    {
        public NotFoundException(string msg) : base(msg)
        { }
    }
    public class NotImplementedException : Exception
    {
        public NotImplementedException(string msg) : base(msg)
        { }
    }
}
