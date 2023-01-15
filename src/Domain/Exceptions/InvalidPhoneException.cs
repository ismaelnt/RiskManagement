using System.Text.RegularExpressions;

namespace Domain.Exceptions;

public partial class InvalidPhoneException : Exception
{
    public InvalidPhoneException(string message = "Phone is invalid") : base(message)
    {
    }

    public static void ThrowIfInvalid(string phone)
    {
        if (!MyRegex().IsMatch(phone))
        {
            throw new InvalidPhoneException();
        }
    }

    [GeneratedRegex("^\\([1-9]{2}\\) [9]{0,1}[6-9]{1}[0-9]{3}\\-[0-9]{4}$")]
    private static partial Regex MyRegex();
}
