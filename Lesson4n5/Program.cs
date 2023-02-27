using System;

public class AtomicInfo
{
    public int atomNum;
    public string symbol, fullName;
    public double atomWeight;
}
public class Employee
{
    public string firstName, lastName, address;
    public double salary, workingTime;
}

public class Lab4n5
{
    public static void Main()
    {
        // Exercise1();
        // Exercise2();
        // Exercise3();
        // Exercise4();  
    }
    // Exercise 1
    public static void QuadraticEquation(float a, float b, float c)
    {
        var delta = Math.Pow(b, 2) - (4 * a * c);
        if (delta == 0)
        {
            Console.Write(" x1 = x2 = " + -b / (2 * a));
        }
        else if (delta < 0)
        {
            Console.Write(" Phuong trinh vo nghiem");
        }
        else if (delta > 0)
        {
            Console.WriteLine(" x1 = " + (-b - Math.Sqrt(delta)) / (2 * a));
            Console.WriteLine(" x2 = " + (-b + Math.Sqrt(delta)) / (2 * a));
        }
    }
    public static void Exercise1()
    {
        QuadraticEquation(4, -2, -6);
    }
    // End Exercise 1
    
    // Exercise 2
    public static void Exercise2()
    {
        Rectangle();
    }
    public static void Rectangle()
    {
        int width = GetWidth();
        int height = GetHeight();
        Display(width, height);
        Console.WriteLine(" Area Of Rectangle Is " + GetArea(width, height));
        SetWidth(ref width);
        SetHeight(ref height);
        Display(width, height);
    }
    public static void Display(int width, int height)
    {
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < width; j++)
            {
                Console.Write("#");
            }
        }
        Console.WriteLine("\n");
    }
    public static int GetArea(int width, int height)
    {
        int area = width * height;
        return area;
    }
    public static void SetHeight(ref int height)
    {
        Console.Write(" Enter Height Of Rectangle: ");
        height = Convert.ToInt32(Console.ReadLine());
    }
    public static int GetPerimeter(int width, int height)
    {
        int perimeter = (width + height) * 2;
        return perimeter;
    }
    public static int GetHeight()
    {
        int height;
        Console.Write("Enter Height Of Rectangle: ");
        height = Convert.ToInt32(Console.ReadLine());
        return height;
    }
    public static int GetWidth()
    {
        int width;
        Console.Write("Enter Width Of Rectangle: ");
        width = Convert.ToInt32(Console.ReadLine());
        return width;
    }
    public static void SetWidth(ref int width)
    {
        Console.Write(" Enter Width Of Rectangle: ");
        width = Convert.ToInt32(Console.ReadLine());
    }
    // End Exercise 2
    
    // Exercise 3

    public static void Exercise3()
    {
        List<AtomicInfo> list = new List<AtomicInfo>();
        list.Add(GetInfo());
        list.Add(GetInfo());
        list.Add(GetInfo());
        Display2(list);
    }
    public static void Display2(List<AtomicInfo> list)
    {
        Console.WriteLine(" ------------------------------ ");
        Console.WriteLine(" Display All Atomic Infomation ");
        Console.WriteLine(" ------------------------------ ");
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(" " + list[i].atomNum);
            Console.Write(" " + list[i].symbol);
            Console.Write(" " + list[i].fullName);
            Console.Write(" " + list[i].atomWeight + "\n");
        }
        Console.WriteLine(" ------------------------------ ");
    }
    public static void GetInf(AtomicInfo atomInfo)
    {
        Console.WriteLine(" ------------------------------ ");
        Console.WriteLine("    Enter Atomic Infomation ");
        Console.WriteLine(" ------------------------------ ");
        Console.Write(" Enter atomic number: ");
        atomInfo.atomNum = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Enter symbol: ");
        atomInfo.symbol = Console.ReadLine();
        Console.Write(" Enter full name: ");
        atomInfo.fullName = Console.ReadLine();
        Console.Write(" Enter atomic weight: ");
        atomInfo.atomWeight = Convert.ToDouble(Console.ReadLine());
    }
    public static AtomicInfo GetInfo()
    {
        AtomicInfo atomInfo = new AtomicInfo();
        GetInf(atomInfo);
        if (Accept(atomInfo) == false)
        {
            GetInf(atomInfo);
        }
        return atomInfo;
    }
    public static bool IsDigitsOnly(string str)
    {
        foreach (char c in str)
        {
            if (c < '0' || c > '9')
                return false;
        }
        return true;
    }
    public static bool Accept(AtomicInfo info)
    {
        if (IsDigitsOnly(info.fullName))
        {
            return false;
        }
        else if (IsDigitsOnly(info.symbol))
        {
            return false;
        }
        return true;
    }
    // End Exercise 3
    
    // Exercise 4
    public static void Exercise4()
    {
        int limit = 0;
        List<Employee> list = new List<Employee>();
        AddEmployee(list, limit);
    }
    public static void AddEmployee(List<Employee> list, int limit)
    {
        if (limit == 5)
        {
            return;
        }
        limit++;
        list.Add(GetEmployeeInfo());
        Display(list);
        AddEmployee(list, limit);
    }
    public override string ToString()
    {
        return base.ToString();
    }
    public static Employee GetEmployeeInfo()
    {
        Employee employee = new Employee();
        Console.WriteLine(" =================================================");
        Console.WriteLine("                 Add Employee Info");
        Console.WriteLine(" =================================================");
        Console.Write(" Enter First Name: ");
        employee.firstName = Console.ReadLine();
        Console.Write(" Enter Last Name: ");
        employee.lastName = Console.ReadLine();
        Console.Write(" Enter Address: ");
        employee.address = Console.ReadLine();
        Console.Write(" Enter Working Time: ");
        employee.workingTime = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Enter Salary (/hour): ");
        employee.salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" =================================================");
        return employee;
    }
    public static void Display(List<Employee> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(" -------------------------------------------------");
            Console.WriteLine(" " + (i + 1) + ". " + list[i].firstName + " " + list[i].lastName);
            Console.WriteLine(" Address: " + list[i].address + ", Salary: " + list[i].salary + " đ");
            Console.WriteLine(" Working Time: " + list[i].workingTime + ", Bonus: " + (list[i].salary * 10/100) + " đ");
            Console.WriteLine(" Total Salary: " + (list[i].salary + list[i].salary * 10/100) + " đ");
        }
    }
    // End Exercise 4 
}