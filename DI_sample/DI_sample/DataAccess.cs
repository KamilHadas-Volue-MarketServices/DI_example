namespace DI_sample
{
    public interface IDataAccess
    {
        string GetData(string query);
    }

    public class DataAccess : IDataAccess
    {
        public string GetData(string query)
        {
            return "Data";
        }
    }
}
