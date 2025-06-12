namespace curso_rocket.Communication.Response;

public class ErrorMessageJson
{
    public List<string> Errors { get; set; }

    public ErrorMessageJson(string message)
    {
        Errors = [message];
        
    }

    public ErrorMessageJson(List<string> messages)
    {
        Errors = messages;

    }
}
