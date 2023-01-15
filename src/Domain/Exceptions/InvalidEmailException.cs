using System.Text.RegularExpressions;

namespace Domain.Exceptions;

public partial class InvalidEmailException : Exception
{
    private InvalidEmailException(string message = "Invalid email") : base(message)
    {
    }

    public static void ThrowIfInvalid(string email)
    {
        if (!MyRegex().IsMatch(email))
            throw new InvalidEmailException();
    }

    [GeneratedRegex("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$")]
    private static partial Regex MyRegex();
}
