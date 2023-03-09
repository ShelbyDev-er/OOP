using Properties;
using Utils;
// FileInfo
// StreamWriter
// StreamReader
namespace Feature
{
    public class Menu
    {
        public void MenuHandle()
        {
            bool active = true;
            Stack<int> prevChoiceStack = new Stack<int>();
            List<Student> studentsList = new List<Student>();
            List<Faculty> facultiesList = new List<Faculty>();
            int choice = 0, level = 0, id = 0, temp = 0;
            while (active)
            {
                if (level == 0)
                {
                    choice = MainMenu();
                    switch (choice)
                    {
                        case 1:
                            NextLevel(ref level);
                            prevChoiceStack.Push(choice);
                            break;
                        case 2:
                            NextLevel(ref level);
                            prevChoiceStack.Push(choice);
                            break;
                        case 3:
                            NextLevel(ref level);
                            prevChoiceStack.Push(choice);
                            break;
                        case 4:
                            NextLevel(ref level);
                            prevChoiceStack.Push(choice);
                            break;
                        case 5:
                            active = false;
                            break;
                        default:
                            UI.Notification("Invalid choice!");
                            UI.PressEnterToContinue();
                            break;
                    }
                }
                else if (level == 1 && choice == 1)
                {
                    choice = StudentMenu();
                    switch (choice)
                    {
                        case 1:
                            StudentFeatures.AddStudent(studentsList);
                            break;
                        case 2:
                            if (StudentFeatures.SearchStudent(studentsList))
                            {
                                temp = StudentFeatures.ViewDetailsStudent(studentsList, ref id);
                                if (temp == 1)
                                    NextLevel(ref level);
                                else if (temp == 0)
                                    BackToMainMenu(ref level);
                                else
                                {
                                    UI.Notification("Not Found!");
                                    choice = 1;
                                    UI.PressEnterToContinue();
                                }
                            }
                            else
                            {
                                UI.Notification("Not Found!");
                                choice = 1;
                                UI.PressEnterToContinue();
                            }
                            break;
                        case 3:
                            if (StudentFeatures.ShowStudentsList(studentsList))
                            {
                                temp = StudentFeatures.ViewDetailsStudent(studentsList, ref id);
                                if (temp == 1)
                                    NextLevel(ref level);
                                else if (temp == 0)
                                    BackToMainMenu(ref level);
                                else
                                {
                                    UI.Notification("Not Found!");
                                    choice = 1;
                                    UI.PressEnterToContinue();
                                }
                            }
                            break;
                        case 4:
                            BackToMainMenu(ref level);
                            break;
                        default:
                            UI.Notification("Invalid choice!");
                            choice = 1;
                            UI.PressEnterToContinue();
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
                            NextLevel(ref level);
                            break;
                        case 3:
                            NextLevel(ref level);
                            break;
                        case 4:
                            NextLevel(ref level);
                            break;
                        case 5:
                            NextLevel(ref level);
                            break;
                        case 6:
                            BackToMainMenu(ref level);
                            break;
                        default:
                            UI.Notification("Invalid choice!");
                            choice = 2;
                            UI.PressEnterToContinue();
                            break;
                    }
                }
                else if (level == 1 && choice == 3)
                {
                    choice = FacultyMenu();
                    switch (choice)
                    {
                        case 1:
                            FacultyFeatures.AddFaculty(facultiesList);
                            choice = 3;
                            break;
                        case 2:
                            if (FacultyFeatures.SearchFaculty(facultiesList))
                            {
                                temp = FacultyFeatures.ViewDetailsFaculty(facultiesList, ref id);
                                if (temp == 1)
                                    NextLevel(ref level);
                                else if (temp == 0)
                                    BackToMainMenu(ref level);
                                else
                                {
                                    UI.Notification("Not Found!");
                                    choice = 1;
                                    UI.PressEnterToContinue();
                                }
                            }
                            else
                            {
                                UI.Notification("Not Found!");
                                choice = 1;
                                UI.PressEnterToContinue();
                            }
                            break;
                        case 3:
                            if (FacultyFeatures.ShowfacultiesList(facultiesList))
                            {
                                temp = FacultyFeatures.ViewDetailsFaculty(facultiesList, ref id);
                                if (temp == 1)
                                    NextLevel(ref level);
                                else if (temp == 0)
                                    BackToMainMenu(ref level);
                                else
                                {
                                    UI.Notification("Not Found!");
                                    choice = 1;
                                    UI.PressEnterToContinue();
                                }
                            }
                            break;
                        case 4:
                            BackToMainMenu(ref level);
                            break;
                        default:
                            UI.Notification("Invalid choice!");
                            choice = 3;
                            UI.PressEnterToContinue();
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
                            UI.Notification("Invalid choice!");
                            choice = 4;
                            UI.PressEnterToContinue();
                            break;
                    }
                }
                else if ((level == 2 && (choice == 2 || choice == 3) && prevChoiceStack.Peek() == 1))
                {
                    choice = StudentSubMenu();
                    switch (choice)
                    {
                        case 1:
                            if (StudentFeatures.UpdateStudentInfo(studentsList, id))
                                PrevLevel(ref level, ref choice, prevChoiceStack);
                            else
                                BackToMainMenu(ref level);
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            PrevLevel(ref level, ref choice, prevChoiceStack);
                            break;
                        default:
                            UI.Notification("Invalid choice!");
                            PrevLevel(ref level, ref choice, prevChoiceStack);
                            break;
                    }
                }
                else if (level == 2 && (choice == 3 || choice == 4 || choice == 5) && prevChoiceStack.Peek() == 2)
                {
                    choice = ClassSubMenu();
                    switch (choice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            PrevLevel(ref level, ref choice, prevChoiceStack);
                            break;
                        default:
                            UI.Notification("Invalid choice!");
                            PrevLevel(ref level, ref choice, prevChoiceStack);
                            break;
                    }
                }
            }
        }
        public void BackToMainMenu(ref int level)
        {
            UI.PressEnterToContinue();
            level = 0;
        }
        public void PrevLevel(ref int level, ref int choice, Stack<int> prevChoiceStack)
        {
            UI.PressEnterToContinue();
            choice = prevChoiceStack.Peek();
            level--;
        }
        public void NextLevel(ref int level)
        {
            level++;
        }
        public int MainMenu()
        {
            string[] menu = new[] { "STUDENT LIST MANAGEMENT", "CLASSES MANAGEMENT", "FACULTY MANAGEMENT", "ADMINSTRATOR", "EXIT" };
            return UI.DynamicMenu("               SCHOOL MANAGEMENT SYSTEM", menu);
        }
        public int StudentMenu()
        {
            string[] menu = new[] { "ADD STUDENT", "SEARCH STUDENTS", "SHOW ALL STUDENTS", "BACK TO MAIN MENU" };
            return UI.DynamicMenu("                 STUDENT LIST MANAGEMENT", menu);
        }
        public int StudentSubMenu()
        {
            string[] menu = new[] { "UPDATE STUDENT INFOMATION", "CHANGE STUDENT STATUS", "CHANGE CLASS", "BACK TO 'STUDENT LIST MANAGEMENT'" };
            return UI.DynamicSubMenu(menu, false);
        }
        public int FacultyMenu()
        {
            string[] menu = new[] { "ADD FACULTY", "SEARCH FACULTIES", "SHOW ALL FACULTIES", "BACK TO MAIN MENU" };
            return UI.DynamicMenu("                  FACULTY MANAGEMENT", menu);
        }
        public int ClassMenu()
        {
            string[] menu = new[] { "ADD CLASS", "STUDYING CLASSES", "COMPLETED CLASSES", "CLOSED CLASSES", "ALL CLASSES", "BACK TO MAIN MENU" };
            return UI.DynamicMenu("                  CLASSES MANAGEMENT", menu);
        }
        public int ClassSubMenu()
        {
            string[] menu = new[] { "UPDATE CLASS INFOMATION", "CHANGE CLASS STATUS", "SHOW STUDENT LIST", "BACK TO 'STUDENT LIST MANAGEMENT'" };
            return UI.DynamicSubMenu(menu, false);
        }
        public int AdminstratorMenu()
        {
            string[] menu = new[] { "SET UP STUDY DAY", "SET UP STUDY TIME", "SET UP CLASSROOM", "BACK TO MAIN MENU" };
            return UI.DynamicMenu("          SCHOOL MANAGEMENT SYSTEM (ADMINSTRATOR)", menu);
        }
    }
}