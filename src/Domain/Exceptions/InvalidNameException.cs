namespace Domain.Exceptions;

public class InvalidNameException : Exception
{
    public InvalidNameException(string message = "Name is required") : base(message)
    {
    }

    public static void ThrowIfInvalid(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new InvalidNameException();
    }

    public static void ThrowIfIsTooShort(string name)
    {
        if (name.Length < 3)
            throw new InvalidNameException("Name is too short");
    }

    public static void ThrowIfIsTooLong(string name)
    {
        if (name.Length > 50)
            throw new InvalidNameException("Name is too long");
    }
}
