using Utils;
using Properties;
namespace Feature
{
    public class StudentMenuHandle
    {
        public static void Feature(List<Student> studentsList, ref int id)
        {
            bool active = true;
            int choice = 0, temp;
            while (active)
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
                                StudentSubMenuHandle.Feature(studentsList, ref id);
                            else if (temp == 0)
                            {
                                UI.PressEnterToContinue();
                                return;
                            }
                            else
                            {
                                UI.Notification("Not Found!");
                                UI.PressEnterToContinue();
                                active = false;
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
                                StudentSubMenuHandle.Feature(studentsList, ref id);
                            else if (temp == 0)
                            {
                                UI.PressEnterToContinue();
                                active = false;
                            }
                            else
                            {
                                UI.Notification("Not Found!");
                                UI.PressEnterToContinue();
                                active = false;
                            }
                        }
                        else
                        {
                            UI.Notification("Not Found!");
                            UI.PressEnterToContinue();
                            return;
                        }
                        break;
                    case 4:
                        return;
                    default:
                        UI.Notification("Invalid choice!");
                        choice = 1;
                        UI.PressEnterToContinue();
                        break;
                }
            }
        }
        public static int StudentMenu()
        {
            string[] menu = new[] { "ADD STUDENT", "SEARCH STUDENTS", "SHOW ALL STUDENTS", "BACK TO MAIN MENU" };
            return UI.DynamicMenu("                 STUDENT LIST MANAGEMENT", menu);
        }
    }
}