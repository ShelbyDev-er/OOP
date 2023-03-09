using Properties;
using Utils;
using Interface;

namespace Feature
{
    public class FacultyFeatures : Features, IFaculty<Faculty>
    {
        public static Faculty GetPersonInfo()
        {
            Faculty faculty = new Faculty();
            faculty.Id = Generate.RandomID();
            faculty.Id = Generate.RandomID();
            faculty.FirstName = UI.GetFieldValue("First Name");
            faculty.MiddleName = UI.GetFieldValue("Middle Name");
            faculty.LastName = UI.GetFieldValue("Last Name");
            faculty.Email = UI.GetFieldValue("Email");
            faculty.Phone = UI.GetFieldValue("Phone");
            faculty.BirthDay = UI.GetFieldValue("BirthDay");
            faculty.Address = UI.GetFieldValue("Address");
            faculty.Note = UI.GetFieldValue("Note");
            Console.WriteLine(" Status: Not Available");
            Console.WriteLine(" Go to detail of this Faculty to change status!");
            faculty.Status = "";
            return faculty;
        }
        public static void AddFaculty(List<Faculty> facultiesList)
        {
            var feature = new FacultyFeatures();
            string? answerOfUser;
            UI.Title("ADD FACULTY");
            feature.CreateFaculty(facultiesList, GetPersonInfo());
            UI.Notification("Add Faculty Completed!");
            answerOfUser = UI.YesOrNoQuestion();
            if (answerOfUser == "Y" || answerOfUser == "y")
            {
                AddFaculty(facultiesList);
            }
            else if (answerOfUser == "N" || answerOfUser == "n")
                return;
            else
            {
                UI.Notification("Invalid Choice!");
            }
        }
        public static bool ShowfacultiesList(List<Faculty> facultiesList)
        {
            var feature = new FacultyFeatures();
            UI.Title("FACULTIES LIST");
            Console.WriteLine(" ID    | Full Name");
            if (!feature.ReadFaculties(facultiesList, -1))
            {
                UI.Notification("Not Found!");
                return false;
            }
            UI.Line();
            return true;
        }
        public static int ViewDetailsFaculty(List<Faculty> facultiesList, ref int id)
        {
            var feature = new FacultyFeatures();
            Console.Write(" Input No To View Details And 0 Or Character To Back Main Menu: ");
            Input.Int(out id);

            if (id == 0)
                return 0;

            UI.Title("FACULTIES DETAILS");

            if (!feature.ReadFaculties(facultiesList, id))
            {
                return -1;
            }

            return 1;
        }
        public static bool UpdateFacultyInfo(List<Faculty> facultiesList, int id)
        {
            int choose;
            var feature = new FacultyFeatures();
            string[] menu = new[] { "First Name", "Middle Name", "Last Name", "Email", "Phone", "Birthday", "Address", "Note", "Status" };
            UI.Title("UPDATE FACULTY INFO");
            UI.DynamicSubMenu(menu, true);
            Console.Write(" Choose To Update: ");
            Input.Int(out choose);
            UI.Title("UPDATE FACULTY INFO");
            if (!feature.UpdateFaculty(facultiesList, id, choose))
            {
                return false;
            }
            UI.Notification("Update Completed");
            UI.PressEnterToContinue();
            return true;
        }
        public static bool SearchFaculty(List<Faculty> facultiesList)
        {
            int count = 0;
            UI.Title("SEARCH FACULTIES");
            Console.Write(" Enter Search Name: ");
            string? searchName = Console.ReadLine();
            UI.Line();
            Console.WriteLine(" ID    | Full Name");
            foreach (Faculty item in facultiesList)
            {
                if (item.LastName == searchName || item.LastName == searchName || item.MiddleName == searchName)
                {
                    Console.WriteLine($" {item.Id} | {item.FullName}\t ");
                    count++;
                }
            }
            UI.Line();
            if (count == 0)
                return false;
            return true;
        }

    }
}