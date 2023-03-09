using Utils;

namespace Feature
{
    public class ClassSubMenuHandle
    {
        public static void Feature()
        {
            bool active = true;
            int choice = 0;
            while (active)
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
                        break;
                    default:
                        break;
                }
            }
        }
        public static int ClassSubMenu()
        {
            string[] menu = new[] { "UPDATE CLASS INFOMATION", "CHANGE CLASS STATUS", "SHOW STUDENT LIST", "BACK TO 'STUDENT LIST MANAGEMENT'" };
            return UI.DynamicSubMenu(menu, false);
        }
    }
}