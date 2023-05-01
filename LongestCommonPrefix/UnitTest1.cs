using System.Text;




//Write a function to find the longest common prefix string amongst an array of strings.

//If there is no common prefix, return an empty string "".

 

//Example 1:

//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"
//Example 2:

//Input: strs = ["dog", "racecar", "car"]
//Output: ""
//Explanation: There is no common prefix among the input strings.



namespace LongestCommonPrefix
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ///Arrange
            string[] str1 = new string[] { "flower", "flow", "flight" };
           
                                                                       
            //Act                                                      
            var result1 = LongestCommonPrefix(str1);
           
            //Assert
            Assert.Equal("fl", result1);    
           
        }
        [Fact]
        public void Test2()
        {
            ///Arrange
           
            string[] str2 = new string[] { "dog", "racear", "car" };
          

            //Act                                                      
            
            var result2 = LongestCommonPrefix(str2);
         

            //Assert
          
            Assert.Equal("", result2);
           
        }
        [Fact]
        public void Test3()
        {
            ///Arrange
           
            string[] str3 = new string[] { "emine", "erdem", "ercan" };

            //Act                                                      
            
            var result3 = LongestCommonPrefix(str3);

            //Assert
            
            Assert.Equal("e", result3);
        }

        public string LongestCommonPrefix(string[] str)
        {
            string shortes = str.OrderBy(p => p.Length).First();
            int index = 0;
            StringBuilder stringBuilder = new StringBuilder(); 
            foreach (char c in shortes)
            {
                if (!str.All(p => p[index] == c)) break;
                stringBuilder.Append(c);
                index++;
            }
            return stringBuilder.ToString();
        }
    }
}