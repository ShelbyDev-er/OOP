using System;

public class Lab2
{
    public static void Main(string[] args)
    {
        Exercise7();
    }
    public static void Exercise2()
    {
        int result = 0;
        int num1, num2, num3;
        Console.Write($" Enter first num:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write($" Enter second num:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write($" Enter third num:");
        num3 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2 && num1 > num3)
        {
            result = num1;
        }
        else if (num2 > num1 && num2 > num3)
        {
            result = num2;
        }
        else if (num3 > num1 && num3 > num2)
        {
            result = num3;
        }
        Console.WriteLine(" Result: " + result);
    }
    public static void Exercise3()
    {
        int j, i, n;
        Console.Write("\n\n");
        Console.Write("Display the multiplication table vertically from 1 to n:\n");
        Console.Write("---------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input upto the table number starting from 1 : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Multiplication table from 1 to {0} \n", n);
        for (i = 1; i <= 10; i++)
        {
            for (j = 1; j <= n; j++)
            {
                if (j <= n - 1)
                    Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                else
                    Console.Write("{0}x{1} = {2}", j, i, i * j);
            }
            Console.Write("\n");
        }
    }
    public static void Exercise4()
    {
        var tax = 0.0825;
        Console.Write(" Input value: ");
        var value = Convert.ToInt32(Console.ReadLine());
        var totalValue = value + (value * tax);
        Console.WriteLine(" Total Value you must pay is: " + totalValue);
    }
    public static void Exercise5n6()
    {
        var maximumWorkingTime = 54;
        Console.Write(" Input Salary Base Per Hour ($): ");
        var salaryBase = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Input Working Time (1 = 1 hour): ");
        var workingTime = Convert.ToInt32(Console.ReadLine());
        if (salaryBase > 5.15)
        {
            var totalSalary = salaryBase * workingTime;
            if (workingTime < maximumWorkingTime)
                Console.Write(" Total Salary Is " + totalSalary);
            else
                Console.Write(" Warning!");
        }
        else
        {
            Console.Write(" Warning!");
        }
    }
    public static void Exercise7()
    {
        Console.WriteLine(" 1. cm to inch");
        Console.WriteLine(" 2. inch to cm");
        Console.WriteLine(" 3. exit");
        Console.Write(" #CHOICE: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Console.Write(" Input cm: ");
            var cm = Convert.ToSingle(Console.ReadLine());
            var inch = cm / 2.54;
            Console.Write(" inch = " + inch);
        }
        else if (choice == 2)
        {
            Console.Write(" Input inch: ");
            var inch = Convert.ToSingle(Console.ReadLine());
            var cm = inch * 2.54;
            Console.Write(" cm = " + cm);
        }
        else if (choice == 3)
        {
            return;
        }
        else
        {
            Console.Write("Please re-enter!");
            Exercise7();
        }
    }
    public static void Exercise8() {
        
    }
    public static void Exercise9() {
        
    }
}
