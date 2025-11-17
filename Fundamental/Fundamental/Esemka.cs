namespace Fundamental;

public class Esemka : Car, IMachine
{
    public void Break()
    {
        System.Console.WriteLine("Duarrrr");
    }

    public void Move()
    {
        System.Console.WriteLine("Ngenggg");
    }

    public override void openDoor()
    {
        System.Console.WriteLine("Gaada pintu");
    }

    public override void openWindow()
    {
        System.Console.WriteLine("Manual");
    }
}