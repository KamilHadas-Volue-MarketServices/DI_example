namespace DI_sample.Controllers;

public interface IDummy
{
    string Guid { get; set; }
}

public class Dummy : IDummy
{
    public Dummy(ICustomClass customClass)
    {
        Guid = customClass.RandomGuid;
    }
    public string Guid { get; set; }
}