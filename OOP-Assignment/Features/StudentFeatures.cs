using Properties;
using Utils;
using Interface;

namespace Feature
{
    public class StudentFeatures : Features, IStudent<Student>
    {
        public static Student GetPersonInfo()
        {
            Student student = new Student();
            student.Id = Generate.RandomID();
            student.FirstName = UI.GetFieldValue("First Name");
            student.MiddleName = UI.GetFieldValue("Middle Name");
            student.LastName = UI.GetFieldValue("Last Name");
            student.Email = UI.GetFieldValue("Email");
            student.Phone = UI.GetFieldValue("Phone");
            student.BirthDay = UI.GetFieldValue("BirthDay");
            student.Address = UI.GetFieldValue("Address");
            student.Note = UI.GetFieldValue("Note");
            Console.WriteLine(" Status: Not Available");
            Console.WriteLine(" Go to detail of this student to change status!");
            student.Status = "";
            return student;
        }
        public static void AddStudent(List<Student> studentsList)
        {
            var feature = new StudentFeatures();
            UI.Title("ADD STUDENT");
            feature.CreateStudent(studentsList, GetPersonInfo());
            UI.Notification("Add Student Completed!");
            string? answerOfUser = UI.YesOrNoQuestion();
            if (answerOfUser == "Y" || answerOfUser == "y")
            {
                AddStudent(studentsList);
            }
            else if (answerOfUser == "N" || answerOfUser == "n")
                return;
            else
            {
                UI.Notification("Invalid Choice!");
            }
        }
        public static bool ShowStudentsList(List<Student> studentsList)
        {
            var feature = new StudentFeatures();
            UI.Title("LIST STUDENTS");
            Console.WriteLine(" ID    | Full Name");
            if (!feature.ReadStudents(studentsList, -1))
            {
                UI.Notification("Not Found!");
                return false;
            }
            UI.Line();
            return true;
        }
        public static int ViewDetailsStudent(List<Student> studentsList, ref int id)
        {
            var feature = new StudentFeatures();
            Console.Write(" Input No To View Details And 0 Or Character To Back Main Menu: ");
            Input.Int(out id);

            if (id == 0)
                return 0;

            UI.Title("STUDENT DETAILS");

            if (!feature.ReadStudents(studentsList, id))
            {
                return -1;
            }

            return 1;
        }
        public static bool UpdateStudentInfo(List<Student> studentsList, int id)
        {
            int choose;
            var feature = new StudentFeatures();
            string[] menu = new[] { "First Name", "Middle Name", "Last Name", "Email", "Phone", "Birthday", "Address", "Note", "Status" };
            UI.Title("UPDATE STUDENT INFO");
            UI.DynamicSubMenu(menu, true);
            Console.Write(" Choose To Update: ");
            Input.Int(out choose);
            UI.Title("UPDATE STUDENT INFO");
            if (!feature.UpdateStudent(studentsList, id, choose))
            {
                return false;
            }
            UI.Notification("Update Completed!");
            UI.PressEnterToContinue();
            return true;
        }
        public static bool SearchStudent(List<Student> studentsList)
        {
            int count = 0;
            UI.Title("SEARCH STUDENTS");
            Console.Write(" Enter Search Name: ");
            string? searchName = Console.ReadLine();
            UI.Line();
            Console.WriteLine(" ID    | Full Name");
            foreach (Student item in studentsList)
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