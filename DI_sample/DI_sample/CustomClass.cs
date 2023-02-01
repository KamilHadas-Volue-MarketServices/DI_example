namespace DI_sample
{
    public class CustomClass
    {
        public string RandomGuid { get; set; }

        public CustomClass()
        {
            RandomGuid = Guid.NewGuid().ToString();
        }
    }
}
