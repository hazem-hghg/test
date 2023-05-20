using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace persons.management.ApiConfigurations;

public class Envelope<T> 
{
    public T Result { get; }
    public string ErrorMessage { get; }
    public DateTime TimeGenerated { get; }
    
    [JsonConstructor]
    public Envelope(T result, string errorMessage)
    {
        Result = result;
        ErrorMessage = errorMessage;
        TimeGenerated = DateTime.Now;
    }
}

public class Envelope : Envelope<string>
{
    protected internal Envelope(string result, [NotNull] string errorMessage) : base(result, errorMessage)
    {
    }

    public static Envelope OK()
    {
        return new Envelope(null, null);
    }

    public static Envelope<T> OK<T>(T result)
    {
        return new Envelope<T>(result, null);
    }

    public static Envelope Error(string message)
    {
        return new Envelope(null, message);
    }
}