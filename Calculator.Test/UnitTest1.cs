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

        Assert.Equal(12, engine.Subtraction(16,4));
    }
}