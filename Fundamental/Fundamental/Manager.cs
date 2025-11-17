using Fundamental;

class Manager<T> : Employee<T>
{
    public float Allowance { get; set; }
    
    public Manager(T id) : base(id)
    {
        System.Console.WriteLine("Instance Manager");
    }

    public override void Introduction()
    {
        base.Introduction();
        System.Console.WriteLine("ALLOWANCE : " + Allowance);
    }
}