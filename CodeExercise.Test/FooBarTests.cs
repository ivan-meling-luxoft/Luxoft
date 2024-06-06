using CodeExercise.Implementation;

namespace CodeExercise.Test;

public class FooBarTests
{
    [Fact]
    public void ShouldFail_InvalidParameter_LowerThanOrEqualsZero()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new FooBar().CalculateFooBar(-1, 1));
        Assert.Throws<ArgumentOutOfRangeException>(() => new FooBar().CalculateFooBar(0, 1));
    }

    [Fact]
    public void ShouldFail_InvalidParameter_GreaterThanOrEqualsFinish()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new FooBar().CalculateFooBar(1, 1));
        Assert.Throws<ArgumentOutOfRangeException>(() => new FooBar().CalculateFooBar(2, 1));
    }

    [Fact]
    public void ShouldPass_Result_OneToTwentyFive()
    {
        var fooBar = new FooBar();
        var start = 1;
        var finish = 25;
        var expectedResult = FooBarMock.FooBar[(start - 1)..finish];

        var actualResult = fooBar.CalculateFooBar(start, finish);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ShouldPass_Result_OneToFifty()
    {
        var fooBar = new FooBar();
        var start = 1;
        var finish = 50;
        var expectedResult = FooBarMock.FooBar[(start - 1)..finish];

        var actualResult = fooBar.CalculateFooBar(start, finish);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ShouldPass_Result_OneToSeventyFive()
    {
        var fooBar = new FooBar();
        var start = 1;
        var finish = 75;
        var expectedResult = FooBarMock.FooBar[(start - 1)..finish];

        var actualResult = fooBar.CalculateFooBar(start, finish);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ShouldPass_Result_OneToOneHundred()
    {
        var fooBar = new FooBar();
        var start = 1;
        var finish = 100;
        var expectedResult = FooBarMock.FooBar[(start - 1)..finish];

        var actualResult = fooBar.CalculateFooBar(start, finish);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ShouldPass_Result_TwoToTwentyFive()
    {
        var fooBar = new FooBar();
        var start = 2;
        var finish = 25;
        var expectedResult = FooBarMock.FooBar[(start - 1)..finish];

        var actualResult = fooBar.CalculateFooBar(start, finish);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ShouldPass_Result_TwoToFifty()
    {
        var fooBar = new FooBar();
        var start = 2;
        var finish = 50;
        var expectedResult = FooBarMock.FooBar[(start - 1)..finish];

        var actualResult = fooBar.CalculateFooBar(start, finish);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ShouldPass_Result_TwoToSeventyFive()
    {
        var fooBar = new FooBar();
        var start = 2;
        var finish = 75;
        var expectedResult = FooBarMock.FooBar[(start - 1)..finish];

        var actualResult = fooBar.CalculateFooBar(start, finish);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ShouldPass_Result_TwpToOneHundred()
    {
        var fooBar = new FooBar();
        var start = 2;
        var finish = 100;
        var expectedResult = FooBarMock.FooBar[(start - 1)..finish];

        var actualResult = fooBar.CalculateFooBar(start, finish);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ShouldPass_Result_ThreeToTwentyFive()
    {
        var fooBar = new FooBar();
        var start = 3;
        var finish = 25;
        var expectedResult = FooBarMock.FooBar[(start - 1)..finish];

        var actualResult = fooBar.CalculateFooBar(start, finish);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ShouldPass_Result_ThreeToFifty()
    {
        var fooBar = new FooBar();
        var start = 3;
        var finish = 50;
        var expectedResult = FooBarMock.FooBar[(start - 1)..finish];

        var actualResult = fooBar.CalculateFooBar(start, finish);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ShouldPass_Result_ThreeToSeventyFive()
    {
        var fooBar = new FooBar();
        var start = 3;
        var finish = 75;
        var expectedResult = FooBarMock.FooBar[(start - 1)..finish];

        var actualResult = fooBar.CalculateFooBar(start, finish);

        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void ShouldPass_Result_ThreeToOneHundred()
    {
        var fooBar = new FooBar();
        var start = 3;
        var finish = 100;
        var expectedResult = FooBarMock.FooBar[(start - 1)..finish];

        var actualResult = fooBar.CalculateFooBar(start, finish);

        Assert.Equal(expectedResult, actualResult);
    }
}
