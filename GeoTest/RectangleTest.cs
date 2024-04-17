namespace GeoTest
{

[TestClass]
public class RectangleTest
{
    [TestMethod]
    public void TestRectangleArea()
    {
         var rectangle = new Rectangle(4, 6); 
        var result = rectangle.CalculateArea();
        Assert.AreEqual(24, result); 
    }

    [TestMethod]
    public void TestRectanglePerimeter()
    {
        var rectangle = new Rectangle(4, 6);
        var result = rectangle.CalculatePerimeter(); 
        Assert.AreEqual(20, result); 
    }
}
}