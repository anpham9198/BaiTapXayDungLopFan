public class Program
{
    private static void Main(string[] args)
    {
        Fan fan1 = new Fan(10,true,10,"yellow");
        Fan fan2 = new Fan(5,false,5,"Blue");

        Console.WriteLine(fan1.ToString());
        Console.WriteLine(fan2.ToString()); 
    }
}