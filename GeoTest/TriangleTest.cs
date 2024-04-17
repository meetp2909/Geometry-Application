namespace GeoTest
{

[TestClass]
public class TriangleTest
{

 [TestMethod]
    public void TestTriangleArea()
    {
        var triangle = new Triangle(3, 4, 5); 
        var result = triangle.CalculateArea();
         Assert.AreEqual(6, result); 
    }

    [TestMethod]
    public void TestTrianglePerimeter()
    {
        var triangle = new Triangle(3, 4, 5); 
        var result = triangle.CalculatePerimeter(); 
       Assert.AreEqual(12, result); 
    }
}
}