using Properties;
// FileInfo
// StreamWriter
// StreamReader
public class Menu
{
    public void MainMenuHandle()
    {
        bool active = true;
        int choice = 0, level = 0, id = 0;
        while (active)
        {
            if (level == 0)
            {
                choice = MainMenu();
                switch (choice)
                {
                    case 1:
                        NextMenu(ref level);
                        break;
                    case 2:
                        NextMenu(ref level);
                        break;
                    case 3:
                        NextMenu(ref level);
                        break;
                    case 4:
                        NextMenu(ref level);
                        break;
                    case 5:
                        active = false;
                        break;
                    default:
                        Console.WriteLine(" Invalid choice!");
                        break;
                }
            }
            else if (level == 1 && choice == 1)
            {
                choice = StudentMenu();
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        Console.WriteLine(Line());
                        Console.WriteLine(" STUDENT LIST");
                        Console.WriteLine(Line());
                        // s.ShowAll(student);
                        Console.Write(" INPUT STUDENT ID TO VIEW DETAIL OR INPUT 0 BACK TO MAIN MENU: ");
                        int.TryParse(Console.ReadLine(), out id);
                        // s.ShowDetail(student);
                        NextMenu(ref level);
                        break;
                    case 4:
                        BackToMainMenu(ref level);
                        break;
                    default:
                        Console.WriteLine(" Invalid choice!");
                        break;
                }
            }
            else if (level == 1 && choice == 2)
            {
                choice = ClassMenu();
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        NextMenu(ref level);
                        break;
                    case 3:
                        NextMenu(ref level);
                        break;
                    case 4:
                        NextMenu(ref level);
                        break;
                    case 5:
                        NextMenu(ref level);
                        break;
                    case 6:
                        BackToMainMenu(ref level);
                        break;
                    default:
                        Console.WriteLine(" Invalid choice!");
                        break;
                }
            }
            else if (level == 1 && choice == 3)
            {
                choice = FacultyMenu();
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        BackToMainMenu(ref level);
                        break;
                    default:
                        Console.WriteLine(" Invalid choice!");
                        break;
                }
            }
            else if (level == 1 && choice == 4)
            {
                choice = AdminstratorMenu();
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        BackToMainMenu(ref level);
                        break;
                    default:
                        Console.WriteLine(" Invalid choice!");
                        break;
                }
            }
            else if (level == 2 && choice == 3)
            {
                choice = StudentSubMenu();
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        PrevMenu(ref level);
                        break;
                    default:
                        Console.WriteLine(" Invalid choice!");
                        break;
                }
            }
            else if (level == 2 && choice == 4)
            {
                choice = StudentSubMenu();
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        PrevMenu(ref level);
                        break;
                    default:
                        Console.WriteLine(" Invalid choice!");
                        break;
                }
            }
        }
    }
    public void BackToMainMenu(ref int level)
    {
        level = 0;
    }
    public void PrevMenu(ref int level)
    {
        level--;
    }
    public void NextMenu(ref int level)
    {
        level++;
    }
    public string Line()
    {
        return "==========================================================";
    }
    public int MainMenu()
    {
        int choice = 0;
        Console.WriteLine(Line());
        Console.WriteLine("               SCHOOL MANAGEMENT SYSTEM");
        Console.WriteLine(Line());
        Console.WriteLine(" 1. STUDENT LIST MANAGEMENT");
        Console.WriteLine(" 2. CLASSES MANAGEMENT");
        Console.WriteLine(" 3. FACULTY MANAGEMENT");
        Console.WriteLine(" 4. ADMINSTRATOR");
        Console.WriteLine(" 5. EXIT");
        Console.WriteLine(Line());
        Console.Write(" #CHOICE: ");
        int.TryParse(Console.ReadLine(), out choice);
        return choice;
    }
    public int StudentMenu()
    {
        int choice = 0;
        Console.WriteLine(Line());
        Console.WriteLine("                 STUDENT LIST MANAGEMENT");
        Console.WriteLine(Line());
        Console.WriteLine(" 1. ADD STUDENT");
        Console.WriteLine(" 2. SEARCH STUDENTS");
        Console.WriteLine(" 3. SHOW ALL STUDENTS");
        Console.WriteLine(" 4. BACK TO MAIN MENU");
        Console.WriteLine(Line());
        Console.Write(" #CHOICE: ");
        int.TryParse(Console.ReadLine(), out choice);
        return choice;
    }
    public int StudentSubMenu()
    {
        int choice = 0;
        Console.WriteLine(Line());
        Console.WriteLine(" 1. UPDATE STUDENT INFOMATION");
        Console.WriteLine(" 2. CHANGE STUDENT STATUS");
        Console.WriteLine(" 3. CHANGE CLASS");
        Console.WriteLine(" 4. BACK TO 'STUDENT LIST MANAGEMENT'");
        Console.WriteLine(Line());
        Console.Write(" #CHOICE: ");
        int.TryParse(Console.ReadLine(), out choice);
        return choice;
    }
    public int FacultyMenu()
    {
        int choice = 0;
        Console.WriteLine(Line());
        Console.WriteLine("                  FACULTY MANAGEMENT");
        Console.WriteLine(Line());
        Console.WriteLine(" 1. ADD FACULTY");
        Console.WriteLine(" 2. SEARCH FACULTIES");
        Console.WriteLine(" 3. SHOW ALL FACULTIES");
        Console.WriteLine(" 4. BACK TO MAIN MENU");
        Console.WriteLine(Line());
        Console.Write(" #CHOICE: ");
        int.TryParse(Console.ReadLine(), out choice);
        return choice;
    }
    public int ClassMenu()
    {
        int choice = 0;
        Console.WriteLine(Line());
        Console.WriteLine("                  CLASSES MANAGEMENT");
        Console.WriteLine(Line());
        Console.WriteLine(" 1. ADD CLASS");
        Console.WriteLine(" 2. STUDYING CLASSES");
        Console.WriteLine(" 3. COMPLETED CLASSES");
        Console.WriteLine(" 4. CLOSED CLASSES");
        Console.WriteLine(" 5. ALL CLASSES");
        Console.WriteLine(" 6. BACK TO MAIN MENU");
        Console.WriteLine(Line());
        Console.Write(" #CHOICE: ");
        int.TryParse(Console.ReadLine(), out choice);
        return choice;
    }
    public int AdminstratorMenu()
    {
        int choice = 0;
        Console.WriteLine(Line());
        Console.WriteLine("          SCHOOL MANAGEMENT SYSTEM (ADMINSTRATOR)");
        Console.WriteLine(Line());
        Console.WriteLine(" 1. SET UP STUDY DAY");
        Console.WriteLine(" 2. SET UP STUDY TIME");
        Console.WriteLine(" 3. SET UP CLASSROOM");
        Console.WriteLine(" 4. BACK TO MAIN MENU");
        Console.WriteLine(Line());
        Console.Write(" #CHOICE: ");
        int.TryParse(Console.ReadLine(), out choice);
        return choice;
    }
}