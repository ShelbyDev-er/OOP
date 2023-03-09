using Properties;
using Utils;

namespace Feature
{
    public class FacultyMenuHandle
    {
        public static void Feature(List<Faculty> facultiesList, ref int id)
        {
            bool active = true;
            int choice = 0;
            while (active)
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
                            FacultyFeatures.ViewDetailsFaculty(facultiesList, ref id);
                        break;
                    case 3:
                        if (FacultyFeatures.ShowfacultiesList(facultiesList))
                            FacultyFeatures.ViewDetailsFaculty(facultiesList, ref id);
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
        public static int FacultyMenu()
        {
            string[] menu = new[] { "ADD FACULTY", "SEARCH FACULTIES", "SHOW ALL FACULTIES", "BACK TO MAIN MENU" };
            return UI.DynamicMenu("                  FACULTY MANAGEMENT", menu);
        }
    }
}