using Utils;
using Properties;

namespace Feature
{
    public class MainMenuHandle
    {
        public static void Feature()
        {
            Stack<int> prevChoiceStack = new Stack<int>();
            List<Student> studentsList = new List<Student>();
            List<Faculty> facultiesList = new List<Faculty>();
            int choice = 0, id = 0;
            bool active = true;
            while (active)
            {
                choice = MainMenu();
                switch (choice)
                {
                    case 1:
                        StudentMenuHandle.Feature(studentsList, ref id);
                        break;
                    case 2:
                        FacultyMenuHandle.Feature(facultiesList, ref id);
                        break;
                    case 3:
                        ClassMenuHandle.Feature();
                        break;
                    case 4:
                        AdminstratorMenuHandle.Feature();
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
        }
        public static int MainMenu()
        {
            string[] menu = new[] { "STUDENT LIST MANAGEMENT", "CLASSES MANAGEMENT", "FACULTY MANAGEMENT", "ADMINSTRATOR", "EXIT" };
            return UI.DynamicMenu("               SCHOOL MANAGEMENT SYSTEM", menu);
        }
    }
}