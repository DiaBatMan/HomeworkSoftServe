using System;

namespace HomeWork2
{
    internal class Program
    {

        private void Main()
        {
            string cmd = "-1";
            int counter=0;

            while (true)
            {
                if (cmd == "new")
                {
                    Factory factory = new Factory();

                    Console.WriteLine("Name of factory: ");
                    factory.Name = Console.ReadLine();

                    Console.WriteLine("Count of employers: ");
                    counter=int.Parse(Console.ReadLine());

                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine("Emplloyee name: ");
                        factory.employee[i].Name = Console.ReadLine();

                        Console.WriteLine("Emplloyee surname: ");
                        factory.employee[i].Surname = Console.ReadLine();

                        Console.WriteLine("Emplloyee birthdate: ");
                        factory.employee[i].BirthDate = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Emplloyee salary: ");
                        factory.employee[i].Salary = decimal.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Count of products: ");
                    counter = int.Parse(Console.ReadLine());

                    for (int i = 0; i < counter; i++)
                    {
                        Console.WriteLine("Product name: ");
                        factory.product[i].Name = Console.ReadLine();

                        Console.WriteLine("Emplloyee birthdate: ");
                        factory.product[i].ManufactureDate = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Emplloyee salary: ");
                        factory.product[i].Price = decimal.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Done!");

                }

                if (cmd == "help")
                {
                    Console.WriteLine("\new - Create new factory\nexit - Close the program\nhelp - Show this text");
                }

                if (cmd == "exit")
                {
                    break;
                }
            }

        }
    }
}