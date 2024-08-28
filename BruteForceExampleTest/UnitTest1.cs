using BruteForceExample;

namespace BruteForceExampleTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1", false)]
        [InlineData("password", false)]
        [InlineData("password0", false)]
        [InlineData("Password0", false)]
        [InlineData("Pas9!", false)]
        [InlineData("password18!", false)]
        [InlineData("Password18!", true)]
        public void CreatePasswordTest(string password, bool expected)
        {
            Assert.Equal(Program.IsPasswordValid(password), expected);
        }

        [Theory]
        [InlineData("b", true)]
        [InlineData("m", false)]
        [InlineData("Password!0", false)]
        public void HackTest(string password, bool expected)
        {
            Assert.Equal(Hacker.Hack(password), expected);
        }
    }
}