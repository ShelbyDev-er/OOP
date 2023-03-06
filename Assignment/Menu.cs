public class Menu
{
    public int GetChoice()
    {
        int choice;
        Console.Write(" #CHOICE: ");
        choice = Convert.ToInt32(Console.ReadLine());
        return choice;
    }
    public void nextLevel(ref int currentLevel)
    {
        currentLevel++;
    }
    public void prevLevel(ref int currentLevel)
    {
        currentLevel--;
    }
    public void nextSubMenu(ref int subMenu)
    {
        subMenu++;
    }
    public void prevSubMenu(ref int subMenu)
    {
        subMenu--;
    }
    public void MenuHandle()
    {
        int choice = 0, currentLevel = 0, subMenu = 1, id = 0;
        bool active = true;
        string? ques = "y", searchName;
        Student student = new Student();
        Class cls = new Class();
        List<Student> studentList = new List<Student>();
        List<Class> classes = new List<Class>();
        while (active)
        {
            if (currentLevel == 0 && subMenu == 1)
            {
                choice = MainMenu();
                switch (choice)
                {
                    case 1:
                        nextLevel(ref currentLevel);
                        break;
                    case 2:
                        nextLevel(ref currentLevel);
                        nextSubMenu(ref subMenu);
                        break;
                    case 3:
                        active = false;
                        Console.WriteLine(" Exiting.. Success!");
                        break;
                    default:
                        Console.Write(" Please Re-enter!");
                        break;
                }
            }
            else if (subMenu == 1 && currentLevel == 1)
            {
                choice = student.StudentListMenu();
                switch (choice)
                {
                    case 1:
                        ques = "y";
                        while (ques == "Y" || ques == "y")
                        {
                            student.Add(studentList);
                            Console.Write(" Do you want to continue? (Y/N): ");
                            ques = Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.Write(" Enter Student Name You Want To Search: ");
                        searchName = Console.ReadLine();
                        while (!student.BinarySearch(studentList, searchName))
                        {
                            Console.WriteLine(" Please Re-enter Student Name! ");
                            Console.Write(" Enter Student Name You Want To Search: ");
                            searchName = Console.ReadLine();
                            student.BinarySearch(studentList, searchName);
                        }
                        break;
                    case 3:
                        student.ShowAll(studentList);
                        Console.Write(" ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (id == 0)
                        {
                            prevLevel(ref currentLevel);
                            break;
                        }
                        while (!student.ShowDetail(studentList, id))
                        {
                            Console.WriteLine(" Please Re-enter ID: ");
                            Console.Write(" ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            student.ShowDetail(studentList, id);
                        }
                        nextLevel(ref currentLevel);
                        break;
                    case 4:
                        prevLevel(ref currentLevel);
                        break;
                    default:
                        break;
                }
            }
            else if (subMenu == 2 && currentLevel == 1)
            {
                choice = cls.ClassesMenu();
                switch (choice)
                {
                    case 1:
                        ques = "y";
                        while (ques == "Y" || ques == "y")
                        {
                            cls.Add(classes);
                            Console.Write(" Do you want to continue? (Y/N): ");
                            ques = Console.ReadLine();
                        }
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        cls.ShowAll(classes);
                        break;
                    case 6:
                        prevSubMenu(ref subMenu);
                        prevLevel(ref currentLevel);
                        break;
                    default:
                        break;
                }
            }
            else if (subMenu == 1 && currentLevel == 2)
            {
                choice = student.StudentDetailMenu();
                switch (choice)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        prevLevel(ref currentLevel);
                        break;
                    default:
                        break;
                }
            }
            else if (subMenu == 2 && currentLevel == 2)
            {
                choice = cls.ClassDetailMenu();
                switch (choice)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        prevLevel(ref currentLevel);
                        break;
                    default:
                        break;
                }
            }
        }
    }
    public int MainMenu()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("          VTC ACADEMY SCHOOL MANAGEMENT");
        Console.WriteLine("==================================================");
        Console.WriteLine(" 1. Student List Management");
        Console.WriteLine(" 2. Classes Management");
        Console.WriteLine(" 3. Exit Application");
        Console.WriteLine("==================================================");
        return GetChoice();
    }
}