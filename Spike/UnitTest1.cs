using Xunit;

namespace Spike
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void IsPassingTest()
        {
            Assert.Equal(5, Add(3, 2));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        int Add(int x, int y)
        { 
            return x + y; 
        }
    }
}

namespace Animal
{
    public class UnitTest2 
    {
        const string classStr = "Animal-UnitTest2";

        [Fact]
        public void stringComp()
        {
            string str1 = "Animal-UnitTest2";
            Assert.True(str1.Equals(classStr));
        }

        [Theory]
        [InlineData("1234567890123456")]
        [InlineData("abcdefghijklmnop")]
        [InlineData("0123456789abcdef")]
        public void TwoBytesHexLen(string value)
        {
            Assert.Equal(value.Length, classStr.Length);
        }
    }
}