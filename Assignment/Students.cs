public class Student : Management
{
    public int StudentID { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? Birthday { get; set; }
    public string? Address { get; set; }
    public string? Note { get; set; }
    
    public int RandomId()
    {
        Random rd = new Random();
        int id = rd.Next();
        return id;
    }
    public int StudentListMenu()
    {
        Menu menu = new Menu();
        Console.WriteLine("==================================================");
        Console.WriteLine(" Student List Management");
        Console.WriteLine("==================================================");
        Console.WriteLine(" 1. ADD STUDENT");
        Console.WriteLine(" 2. SEARCH STUDENTS");
        Console.WriteLine(" 3. SHOW ALL STUDENTS");
        Console.WriteLine(" 4. BACK TO MAIN MENU");
        Console.WriteLine("==================================================");
        return menu.GetChoice();
    }
    public int StudentDetailMenu()
    {
        Menu menu = new Menu();
        Console.WriteLine("==================================================");
        Console.WriteLine(" 1. UPDATE STUDENT INFOMATION");
        Console.WriteLine(" 2. CHANGE STUDENT STATUS");
        Console.WriteLine(" 3. CHANGE CLASS");
        Console.WriteLine(" 4. BACK TO 'STUDENT LIST MANAGEMENT'");
        Console.WriteLine("==================================================");
        return menu.GetChoice();
    }
    public Student GetStudentInfo()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine(" ADD STUDENT");
        Console.WriteLine("==================================================");
        Student student = new Student();
        student.StudentID = RandomId();
        Console.Write(" First Name: ");
        student.FirstName = Console.ReadLine();
        Console.Write(" Middle Name: ");
        student.MiddleName = Console.ReadLine();
        Console.Write(" Last Name: ");
        student.LastName = Console.ReadLine();
        Console.Write(" Birthday: ");
        student.Birthday = Console.ReadLine();
        Console.Write(" Address: ");
        student.Address = Console.ReadLine();
        Console.Write(" Note: ");
        student.Note = Console.ReadLine();
        student.Status = false;
        return student;
    }
    public void Add(List<Student> list)
    {
        list.Add(GetStudentInfo());
        Console.Write(" Adding.. Success!");
        Console.ReadKey();
    }
    public void Update(List<Student> list, int id)
    {
        for (int i = 0; i < list.Count(); i++)
        {
            if (list[i].StudentID == id)
            {
                Console.Write(" First Name: ");
                list[id].FirstName = Console.ReadLine();
                Console.Write(" Middle Name: ");
                list[id].MiddleName = Console.ReadLine();
                Console.Write(" Last Name: ");
                list[id].LastName = Console.ReadLine();
                Console.Write(" Birthday: ");
                list[id].Birthday = Console.ReadLine();
                Console.Write(" Address: ");
                list[id].Address = Console.ReadLine();
                Console.Write(" Note: ");
                list[id].Note = Console.ReadLine();
            }
        }
        Console.Write(" Updating.. Success!");
        Console.ReadKey();
    }
    public void Delete(List<Student> list, int id)
    {
        for (int i = 0; i < list.Count(); i++)
        {

        }
        Console.Write(" Deleting.. Success!");
        Console.ReadKey();
    }
    public bool BinarySearch(List<Student> list, string searchName)
    {
        searchName = "abc";
        return false;
    }
    public void ShowAll(List<Student> list)
    {
        Console.WriteLine("==================================================");
        Console.WriteLine(" STUDENT LIST");
        Console.WriteLine("==================================================");
        Console.WriteLine("       ID       |            FULL NAME      ");
        Console.WriteLine("==================================================");
        foreach (Student item in list)
        {
            Console.WriteLine($" {item.StudentID} \t| {item.FirstName} {item.MiddleName} {item.LastName}");
        }
    }
    public bool ShowDetail(List<Student> list, int id)
    {
        foreach (Student item in list)
        {
            if (item.StudentID == id)
            {
                Console.WriteLine(" item.lastName -> " + item.LastName);
                return true;
            }
        }
        return false;
    }
    // public void ChangeStatus(bool status)
    // {
    //     if (status == true)
    //         status = false;

    //     else
    //         status = true;
    // }
}