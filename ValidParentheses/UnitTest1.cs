namespace ValidParentheses
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            string s = "()";

            //Act
            var result = ValidParentheses(s);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            string s = "()[]{}";

            //Act
            var result = ValidParentheses(s);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            string s = "(]";

            //Act
            var result = ValidParentheses(s);

            //Assert
            Assert.False(result);
        }

        public bool ValidParentheses(string s)
        {
            while (s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
            {
                s=s.Replace("()", "").Replace("{}", "").Replace("[]", "");
            }

            return s.Length == 0;
        }
    }
}