namespace RemoveElement
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int[] list1 = new int[] { 3, 2, 2,3 };
            int[] list2 = new int[] { 0, 1, 2, 2,3,0,4,2 };

            //Act
            var result1 = RemoveElement(list1, 3);
            var result2 = RemoveElement(list2, 2);

            //Assert
            Assert.Equal(2, result1);
            Assert.Equal(5, result2);

        }

        public int RemoveElement(int[] nums,int val)
        {
            int res= 0;
            for(int i =0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[res] = nums[i];
                    res++;
                }
            }
            return res;
        }   
    }
}