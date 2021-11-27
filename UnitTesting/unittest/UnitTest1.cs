using backend;
using Xunit;

namespace unittest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

        double a = 1;
        double b = 2;
        double expected = 4;

        double actual = MyMath.Sum(a, b);

        Assert.Equal(expected, actual);


    }
}