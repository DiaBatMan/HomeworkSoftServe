using System;


public class Factory
{
	public string Name;
	public Employee[] employee;
    public Products[] product;

	private decimal AvgSalary 
    {
        get
        {
            decimal sum=0;
            for (int i = 0; i < employee.Length; i++)
            {
                sum = sum + employee[i].Salary;
            }

            return sum / employee.Length;
        }
    }
    private decimal TotalSalary 
    { 
        get
        {
            decimal sum = 0;

            for (int i = 0; i < employee.Length; i++)
            {
                sum = sum + employee[i].Salary;
            }

            return sum;
        }
    }
    private decimal GDP 
    {
        get
        {
            decimal sum = 0;

            for (int i = 0; i < products.Length; i++)
            {
                sum = sum + products[i].Price;
            }

            return sum / employee.Length;

        }
    }
    private decimal EmpCount 
    {
        get
        {
            return employee.Length;
        }
    }

    public override string ToString()
    {
        string info = "\nName: " + Name + "\nAvgSalary: " + AvgSalary + "\nTotalSalary: " + TotalSalary + "\nGDP: " + GDP+"EmpCount: "+ EmpCount;

        return info;
    }
}
