namespace Calculator.Test;

public class CalculatorTests
{
    [Fact(DisplayName = "When sum should success.")]
    public void WhenSum_Sucess()
    {
        //arrane
        const int resultExpect = 138;
        const int a = 56;
        const int b = 82;
        
        // act
        var resultActual  = Calculator.Sum(a, b);
        
        Assert.Equal(resultExpect, resultActual); 
    }
}