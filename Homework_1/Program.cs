using System;


namespace HomeWork_1
{
    ////////////////////// ( 1 ) //////////////////////

    //internal class Program_1
    //{             
    //    private static void Main()
    //    {

    //        int spaces = 0;

    //        ConsoleKeyInfo keyInfo;

    //        do
    //        {
    //            keyInfo=Console.ReadKey();

    //            if(keyInfo.Key == ConsoleKey.Spacebar)
    //            {
    //                spaces++;
    //            }

    //        }while(keyInfo.Key != ConsoleKey.OemPeriod);

    //        Console.WriteLine("\nSpaces = "+spaces);
    //    }
    //}

    ////////////////////// ( 2 ) //////////////////////

    //internal class Program_2
    //{
    //    private static void Main()
    //    {
    //        string? inputTicketNumber;
    //        int TicketNumber;
    //        bool error;

    //        Console.WriteLine("Enter ticket number: ");

    //        do
    //        {
    //            inputTicketNumber = Console.ReadLine();

    //            if(!int.TryParse(inputTicketNumber, out TicketNumber))
    //            {
    //                Console.WriteLine("Wrong characters");
    //                error = true;
    //                continue;

    //            }


    //            if (inputTicketNumber.Length > 6 || inputTicketNumber.Length < 6)
    //            {
    //                Console.WriteLine("ticket number must contain six numbers");
    //                error = true;
    //                continue;
    //            }

    //            error = false;

    //        } while (error);


    //        inputTicketNumber.ToCharArray();

    //        if (inputTicketNumber[0] + inputTicketNumber[1] + inputTicketNumber[2]
    //            == inputTicketNumber[3] + inputTicketNumber[4] + inputTicketNumber[5])
    //        {
    //            Console.WriteLine("Lucky ticket");
    //        }

    //        else
    //        {
    //            Console.WriteLine("Unlucky ticket(");
    //        }

    //    }
    //}

    ////////////////////// ( 3 ) //////////////////////
    //internal class Program_3
    //{
    //    private static void Main()
    //    {
    //        int A = 0;
    //        int B = 0;
    //        string? inputA;
    //        string? inputB;
    //        bool error;

    //        do
    //        {
    //            Console.WriteLine("Enter A: ");
    //            inputA = Console.ReadLine();


    //            Console.WriteLine("Enter B: ");
    //            inputB = Console.ReadLine();

    //            if(!int.TryParse(inputB, out B)|| !int.TryParse(inputA, out A))
    //            {
    //                Console.WriteLine("Wrong characters");
    //                error = true;
    //                continue;

    //            }

    //            if (B < A || A == B)
    //            {
    //                Console.WriteLine("A must be lower than B");
    //                error=true;
    //                continue;
    //            }

    //            error = false;

    //        } while (error);

    //        for (int i = A; i <= B; i++)
    //        {
    //            for (int j = 0; j < i; j++)
    //            {
    //                Console.Write(i + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }


    //}

    ////////////////////// ( 4 ) //////////////////////

    //internal class Program_4
    //{
    //    private static void Main()
    //    {
    //        string? inputNumber;
    //        int number;

    //        do
    //        {

    //            Console.WriteLine("Enter natural number: ");
    //            inputNumber = Console.ReadLine();             

    //            if (!int.TryParse(inputNumber, out number))
    //            {
    //                Console.WriteLine("Wrong characters");
    //                continue;
    //            }

    //            if (number < 1)
    //            {
    //                Console.WriteLine("Number must be heigher than 0");
    //            }

    //        } while (number < 1);

    //        inputNumber.ToCharArray();

    //        for (int i = inputNumber.Length-1; i >= 0; i--)
    //        {
    //            Console.Write(inputNumber[i]);
    //        }


    //    }
    //}


}