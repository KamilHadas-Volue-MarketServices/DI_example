namespace DI_sample
{
    public interface IDataAccess
    {
        string GetData(string query);
        int CorrectNumberOfLegs(string animalKind);
    }

    public class DataAccess : IDataAccess
    {
        public string GetData(string query)
        {
            return "Data";
        }

        public int CorrectNumberOfLegs(string animalKind)
        {
            return 4;
        }
    }

    public class Animal
    {
        private readonly IDataAccess _dataAccess;

        public Animal(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public bool DoesHaveCorrectNumberOfLegs(string animalKind)
        {
            var expectedNumber =_dataAccess.CorrectNumberOfLegs(animalKind);
            return expectedNumber == 4;
        }
    }
}
