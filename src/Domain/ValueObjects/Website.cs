namespace Domain.ValueObjects;

public class Website
{
    public Website(string url)
    {
        if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
        {
            throw new ArgumentException("Website url is not valid", nameof(url));
        }

        Url = url;
    }

    public string Url { get; }
}
