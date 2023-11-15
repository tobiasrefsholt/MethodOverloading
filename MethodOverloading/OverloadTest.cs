namespace MethodOverloading;

public class OverloadTest
{
    public void PrintMessage(int number, string somethingSomething)
    {
        Console.WriteLine($"Du skrev denne stringen \"{somethingSomething}\" og dette tallet \"{number}\"");
    }
    
    public void PrintMessage(double desimal, string somethingSomething)
    {
        int number = Convert.ToInt32(Math.Round(desimal));
        Console.WriteLine($"Du skrev denne stringen \"{somethingSomething}\" og dette tallet \"{number}\"");
    }
}