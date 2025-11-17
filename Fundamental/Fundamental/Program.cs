namespace Fundamental;

using System;

class Program
{
    static void Main(string[] args)
    {

        // Employee adin = new Employee(321, "Mohamad", 200, "SWE");
        // adin.Introduction();

        Employee<int> employee = new Employee<int>(0);
        Manager<int> manager = new Manager<int>(1003);

        employee.Id = 123;
        employee.FullName = "employee";
        employee.Salary = 10000f;
        employee.Job = "Intern";
        employee.Introduction();
        Console.WriteLine(employee.CalculateTax());

        manager.FullName = "manager";
        manager.Allowance = 1000f;
        manager.Introduction();

        Audi a8 = new Audi();

        a8.MaxGear = 6;
        a8.TopSpeed = 100;
        a8.isManual = false;
        a8.Break();
        a8.Move();
        a8.openDoor();
        a8.openWindow();

        Esemka esemka = new Esemka();
        IMachine agya = new Esemka();

        List<int> numbers = new List<int> { 9, 2, 3 };
        numbers.Add(4);
        numbers.Add(5);
        numbers.Remove(9);
        numbers.RemoveAt(1);

        foreach (var i in numbers)
        {
            System.Console.WriteLine(i);
        }

        List<Employee<int>> employees =
        [
            new Employee<int>(1)
            {
                FullName = "Ucup",
                Salary = 1203f,
                Job = "CEO"
            },
        ];


        foreach (var j in employees)
        {
            j.Introduction();
        }

        List<Employee<int>> test = new List<Employee<int>>(2);
        employee.FullName = "jokowi";
        employee.Salary = 5000f;
        employee.Job = "nganggur";

        test.Add(employee);

        foreach (var item in test)
        {
            item.Introduction();
        }




        // Employee employee = new Employee("E001", "John Doe", 5000000, "Software Engineer");
        // employee.Introduction();
    }
}
