public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void DoSomething()
    {
        // Some code that might throw an exception
        try
        {
            // ... some code here that may throw an exception
            int result = 10 / 0; // Simulate an exception
        }
        catch (DivideByZeroException ex)
        {
            // Handle the exception. this is crucial
            Console.WriteLine("Exception caught: " + ex.Message);
        }
        finally
        {
            // cleanup code. This is important
            Console.WriteLine("Finally block executed");
        }
    }
}