using DI_sample;
using Moq;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var dataAccessMock = new Mock<IDataAccess>();
            dataAccessMock.Setup(m => m.CorrectNumberOfLegs(It.IsAny<string>())).Returns(4);
        }
    }
}