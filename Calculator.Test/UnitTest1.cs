namespace Simple_Console_Calculator;
using Xunit;
public class UnitTest1
{
    [Fact]
    public void Test_Addition()
    {
        Calc engine = new Calc();

        Assert.Equal(10, engine.Add(6,4));
    }

     [Fact]
    public void Test_Subtraction()
    {
        Calc engine = new Calc();

        Assert.Equal(12, engine.Subtract(16,4));
    }
    
     [Fact]
    public void Test_Division()
    {
        Calc engine = new Calc();

        Assert.Equal(4, engine.Divide(16,4));
    }
    
     [Fact]
    public void Test_Multiplication()
    {
        Calc engine = new Calc();

        Assert.Equal(40, engine.Multiply(10,4));
    }
}
