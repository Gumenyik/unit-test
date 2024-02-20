namespace MyCalc.Tests
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
            Class1 c = new Class1();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}