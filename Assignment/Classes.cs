public class Class : Management
{
    public string? StudyDay { get; set; }
    public string? StudyTime { get; set; }
    public string? ClassRoom { get; set; }
    public string? Faculty { get; set; }
    public Class GetClassInfo() {
        Console.WriteLine("==================================================");
        Console.WriteLine(" ADD CLASS");
        Console.WriteLine("==================================================");
        Class cls = new Class();
        Console.Write(" Class Name: ");
        cls.ClassName = Console.ReadLine();
        Console.Write(" Study Day: ");
        cls.StudyDay = Console.ReadLine();
        Console.Write(" Study Time: ");
        cls.StudyTime = Console.ReadLine();
        Console.Write(" Class Room: ");
        cls.ClassRoom = Console.ReadLine();
        Console.Write(" Faculty: ");
        cls.Faculty = Console.ReadLine();
        return cls;
    }
    public void Add(List<Class> list) {
        list.Add(GetClassInfo());
        Console.WriteLine(" Adding.. Success!");
    }
    public void ShowAll(List<Class> list) {
        Console.WriteLine("==================================================");
        Console.WriteLine(" CLASS LIST");
        Console.WriteLine("==================================================");
        foreach (Class item in list)
        {
            Console.WriteLine("item.ClassName -> " + item.ClassName);
        }
    }
    Menu menu = new Menu();
    public int ClassesMenu()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine(" CLASSES MANAGEMENT");
        Console.WriteLine("=================================================");
        Console.WriteLine(" 1. ADD CLASS");
        Console.WriteLine(" 2. STUDYING CLASSES");
        Console.WriteLine(" 3. COMPLETED CLASSES");
        Console.WriteLine(" 4. CLOSED CLASSES");
        Console.WriteLine(" 5. ALL CLASSES");
        Console.WriteLine(" 6. BACK TO MAIN MENU");
        Console.WriteLine("==================================================");
        return menu.GetChoice();
    }
    public int ClassDetailMenu()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine(" 1. UPDATE CLASS INFOMATION");
        Console.WriteLine(" 2. CHANGE CLASS STATUS");
        Console.WriteLine(" 3. SHOW STUDENT LIST");
        Console.WriteLine(" 4. BACK TO 'CLASSES MANAGEMENT'");
        Console.WriteLine("==================================================");
        return menu.GetChoice();
    }
}