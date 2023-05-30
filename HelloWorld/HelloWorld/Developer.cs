namespace HelloWorld;

public class Developer: IEmployee
{
    public string Name { get; set; }

    public void canWriteCode()
    {
        Console.WriteLine("learn how to write clean code!");
    }
}