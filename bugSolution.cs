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
        try
        {
            // ... some code here that may throw an exception
            int result = 10 / 0; // Simulate an exception
        }
        catch (DivideByZeroException ex)
        {
            // Handle the exception robustly
            Console.WriteLine($"Exception caught: {ex.Message}\nStack Trace: {ex.StackTrace}");
            // Take corrective actions or log the error appropriately
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            // Cleanup resources here, regardless of exception
            Console.WriteLine("Finally block executed - resources cleaned up");
        }
    }
}