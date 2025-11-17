namespace Fundamental;

public abstract class Car
{
    public int MaxGear { get; set; }
    public int TopSpeed { get; set; }
    public bool isManual { get; set; }

    public abstract void openDoor();
    public abstract void openWindow();

}