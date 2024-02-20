namespace unit_test.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            //act
            Program c = new Program();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}