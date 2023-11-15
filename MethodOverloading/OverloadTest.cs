namespace MethodOverloading;

public class OverloadTest
{
    public int Number;
    public double desimal;
    public string SomethingSomething;

    /*public OverloadTest(double desimal, string somethingSomething)
    {
        double Desimal = desimal;
        string SomethingSomething = somethingSomething;
    }*/
    
    /*public OverloadTest(int number, string somethingSomething)
    {
        Number = number;
        SomethingSomething = somethingSomething;
    }*/

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