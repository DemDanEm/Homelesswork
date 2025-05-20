
using System.Reflection.Metadata.Ecma335;


public class DummbIdiotException : Exception
{
     DummbIdiotException() : base() {}
     public DummbIdiotException(string message) : base(message) { }


     public DummbIdiotException(string message, Exception? exception) : base(message, exception) { }
}

class Calc
{
    static public int? iadd(int? a, int? b)
    {
        int result;

        try
        {
            result = (int)a + (int)b;
        }
        catch (Exception ex)
        { throw new ArithmeticException("Addition Error", ex); }

        return result;
    }

    static public int isub(int? a, int? b)
    {
        int? calc = null;
        int result;
        try
        {
            calc = a - b;
        }
        catch (ArithmeticException ex)
        {
            throw new ArithmeticException("Subtraction error", ex);
        }
        finally
        {
            try
            {
                result = (int)calc;
            }
            catch (Exception ex)
            {
                throw new ArithmeticException("Null detected", ex);
            }
        }
        return result;
    }


    static public double idiv(double? a, double? b)
    {

        double result;

        try
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            result = (double)a / (double)b;
        }
        catch (InvalidOperationException ex)
        {
            throw new InvalidOperationException("There is Nothing there", ex);
        }
        catch (DivideByZeroException ex)
        {
            throw new DivideByZeroException("Stuupit, have you learned math?", ex);
        }

        return result;
    }

    static public int imult(int? a, int? b)
    {
        int result;
        try
        {
            result = (int)a * (int)b;
        }
        catch (InvalidOperationException ex)
        {
            throw new DummbIdiotException("U stupit", ex);
        }

        return result ;
    }
}





namespace Homelesswork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calc.imult(1, null);
        }
    }
}
