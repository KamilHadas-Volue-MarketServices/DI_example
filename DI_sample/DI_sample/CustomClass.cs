namespace DI_sample
{
    public interface ICustomClass
    {
        string RandomGuid { get; set; }
    }

    public class CustomClass : ICustomClass
    {
        public string RandomGuid { get; set; }

        public CustomClass()
        {
            RandomGuid = Guid.NewGuid().ToString();
        }
    }
}
