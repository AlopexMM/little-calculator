
namespace Term.Calculator.MathLibs;

public class Sum
{
    public static int Result(int[] nums)
    {
        var result = 0;
        foreach ( var number in nums)
        {
            result += number;
        }
        return result;
    }
}