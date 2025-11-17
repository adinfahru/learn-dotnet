namespace Fundamental;

using System;

public class Employee<T>
{
    public T Id { get; set; }
    public string? FullName { get; set; }
    private float salary;
    public string? Job { get; set; }

    public Employee(T id)
    {
        Id = id;
        System.Console.WriteLine("Instance Manager");
    }

    public float Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
            {
                return;
            }
            salary = value;
        }
    }

    public virtual void Introduction()
    {
        Console.WriteLine("=========");
        Console.WriteLine("ID : " + Id);
        Console.WriteLine("NAME : " + FullName);
        Console.WriteLine("SALARY : " + salary);
        Console.WriteLine("JOB : " + Job);
    }

    public float CalculateTax()
    {
        float tax = 2.5f;
        return salary * tax;

    }

    public float CalculateTax(float additionalFee)
    {
        float tax = 2.5f;
        return salary * tax * additionalFee;
    }

    public float CalculateTax(int biayaTambah)
    {
        float tax = 2.5f;
        return salary * tax * biayaTambah;
    }
}