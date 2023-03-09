using Utils;

namespace Feature
{
    public class ClassMenuHandle
    {
        public static void Feature()
        {
            bool active = true;
            int choice = 0;
            while (active)
            {
                choice = ClassMenu();
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
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        UI.Notification("Invalid choice!");
                        UI.PressEnterToContinue();
                        break;
                }
            }
        }
        public static int ClassMenu()
        {
            string[] menu = new[] { "ADD CLASS", "STUDYING CLASSES", "COMPLETED CLASSES", "CLOSED CLASSES", "ALL CLASSES", "BACK TO MAIN MENU" };
            return UI.DynamicMenu("                  CLASSES MANAGEMENT", menu);
        }
    }
}