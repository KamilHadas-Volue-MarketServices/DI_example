using Components;
using DI_sample;
using FluentAssertions;
using Moq;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly Mock<ISupplyNumber> _numberProviderMock;
        public UnitTest1()
        {
            _numberProviderMock = new Mock<ISupplyNumber>();
            _numberProviderMock.Setup(m => m.GetNumber()).Returns(20);
        }
        [Fact]
        public void Test1()
        {
            var dataAccessMock = new Mock<IDataAccess>();
            dataAccessMock.Setup(m => 
                m.CorrectNumberOfLegs(It.IsAny<string>())).Returns(2);

            var sut = new Animal(dataAccessMock.Object);

            var result = sut.DoesHaveCorrectNumberOfLegs("Duck");
            result.Should().BeTrue();
        }
        [Fact]
        public void CalculateWithLoop_WithNumber20_BeGratherThan7()
        {

            var sut = new FactorialCalculator(_numberProviderMock.Object);

            var result = sut.CalculateWithLoop();

            result.Should().BeGreaterThan(7);
        }

        [Theory]
        [InlineData(1,1)]
        [InlineData(2,2)]
        [InlineData(3,6)]
        [InlineData(7,24)]
        [InlineData(5,120)]
        public void InlineDataTest(int supplyNumber, long expectedResult)
        {
            var numberProviderMock = new Mock<ISupplyNumber>();
            numberProviderMock.Setup(m => m.GetNumber()).Returns(supplyNumber);

            var sut = new FactorialCalculator(numberProviderMock.Object);
            var result = sut.CalculateRecursively();

            result.Should().Be(expectedResult);
        }


        [Fact]
        public void Test3()
        {

            var sut = new FactorialCalculator(_numberProviderMock.Object);

            var result = sut.CalculateRecursively();

            result.Should().BeGreaterThan(7);
        }
    }
}