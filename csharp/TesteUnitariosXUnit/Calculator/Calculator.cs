namespace Calculator;

public class Calculator
{
    public static int Sum(int a, int b)
    {
        if (a < 0 || b < 0)
        {
            return -1;
        }
        
        return a + b;
    }
}