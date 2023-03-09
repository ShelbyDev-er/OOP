using Utils;

namespace Feature
{
    public class AdminstratorMenuHandle
    {
        public static void Feature()
        {
            bool active = true;
            int choice = 0;
            while (active)
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
                        break;
                    default:
                        UI.Notification("Invalid choice!");
                        UI.PressEnterToContinue();
                        break;
                }
            }
        }
        public static int AdminstratorMenu()
        {
            string[] menu = new[] { "SET UP STUDY DAY", "SET UP STUDY TIME", "SET UP CLASSROOM", "BACK TO MAIN MENU" };
            return UI.DynamicMenu("          SCHOOL MANAGEMENT SYSTEM (ADMINSTRATOR)", menu);
        }
    }
}