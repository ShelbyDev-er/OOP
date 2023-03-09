using Utils;
using Properties;

namespace Feature
{
    public class StudentSubMenuHandle
    {
        public static void Feature(List<Student> studentsList, ref int id)
        {
            var temp = new StudentSubMenuHandle();
            bool active = true;
            int choice = 0;
            while (active)
            {
                choice = StudentSubMenu();
                switch (choice)
                {
                    case 1:
                        if (StudentFeatures.UpdateStudentInfo(studentsList, id))
                            active = false;
                        else
                        {
                            UI.Notification("Invalid Choice!");
                            active = false;
                        }
                        break;
                    case 2:
                        if(StudentFeatures.ChangeStatus(studentsList, id)) {
                            UI.Notification("Change Status Completed!");
                            active = false;
                            UI.PressEnterToContinue();
                        } else {
                            UI.Notification("Invalid Choice!");
                            active = false;
                            UI.PressEnterToContinue();
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        active = false;
                        break;
                    default:
                        UI.Notification("Invalid choice!");
                        break;
                }
            }
        }
        public static int StudentSubMenu()
        {
            string[] menu = new[] { "UPDATE STUDENT INFOMATION", "CHANGE STUDENT STATUS", "CHANGE CLASS", "BACK TO 'STUDENT LIST MANAGEMENT'" };
            return UI.DynamicSubMenu(menu, false);
        }
    }
}