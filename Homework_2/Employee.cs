using System;

public class Employee
{
    public string Name;
    public string Surname;
    public DateTime BirthDate;
    public decimal Salary;
    
    public override string ToString()
    {
        string info = "\nName: "+Name+"\nSurname: "+Surname+"\nBirthDate: "+BirthDate+"\nSalary: "+Salary;

        return info;
    }
}
