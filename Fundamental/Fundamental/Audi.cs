namespace Fundamental;

public class Audi : Car, IMachine
{
    public void Break()
    {
        System.Console.WriteLine("Injek Rem");
    }

    public void Move()
    {
        System.Console.WriteLine("Injek Gas");
    }

    public override void openDoor()
    {
        System.Console.WriteLine("Keatas");
    }

    public override void openWindow()
    {
        System.Console.WriteLine("Sliding window");
    }
}