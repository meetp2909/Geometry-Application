namespace GeoTest
{
[TestClass]
public class SquareTest
{
    [TestMethod]
    public void TestSquareArea()
    {
        var square = new Square(5);
        var result = square.CalculateArea(); 

        Assert.AreEqual(25, result); 
        }

    [TestMethod]
    public void TestSquarePerimeter()
    {
        var square = new Square(5); 

        var result = square.CalculatePerimeter(); 
        Assert.AreEqual(20, result); 
    }

}
}