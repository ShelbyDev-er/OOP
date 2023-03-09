using Utils;
using Properties;
using Interface;

namespace Feature
{
    public class Features : IStudent<Student>, IFaculty<Faculty>
    {
        public void CreateStudent(List<Student> list, Student student)
        {
            list.Add(student);
        }
        public bool ReadStudents(List<Student> list, int id)
        {
            if (id <= 0)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    Console.WriteLine($" {list[i].Id} | {list[i].FullName}\t ");
                }
                return true;
            }
            else if (id > 0)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    if (list[i].Id == id)
                    {
                        Console.WriteLine($" First Name: {list[i].FirstName}");
                        Console.WriteLine($" Middle Name: {list[i].MiddleName}");
                        Console.WriteLine($" LastName: {list[i].LastName}");
                        Console.WriteLine($" Email: {list[i].Email}");
                        Console.WriteLine($" Phone: {list[i].Phone}");
                        Console.WriteLine($" BirthDay: {list[i].BirthDay}");
                        Console.WriteLine($" Address: {list[i].Address}");
                        Console.WriteLine($" Note: {list[i].Note}");
                        Console.WriteLine($" Status: {list[i].Status}");
                        return true;
                    }
                }
            }
            return false;
        }
        public bool UpdateStudent(List<Student> list, int id, int fieldID)
        {
            foreach (Student item in list)
            {
                if (item.Id == id)
                {
                    switch (fieldID)
                    {
                        case 1:
                            item.FirstName = UI.GetFieldValue("First Name");
                            return true;
                        case 2:
                            item.MiddleName = UI.GetFieldValue("Middle Name");
                            return true;
                        case 3:
                            item.LastName = UI.GetFieldValue("Last Name");
                            return true;
                        case 4:
                            item.Email = UI.GetFieldValue("Email");
                            return true;
                        case 5:
                            item.Phone = UI.GetFieldValue("Phone");
                            return true;
                        case 6:
                            item.BirthDay = UI.GetFieldValue("BirthDay");
                            return true;
                        case 7:
                            item.Address = UI.GetFieldValue("Address");
                            return true;
                        case 8:
                            item.Note = UI.GetFieldValue("Note");
                            return true;
                        default:
                            return false;
                    }
                }
            }
            return true;
        }
        public static bool MenuStatusChooserHandle(Student item)
        {
            UI.Title("STATUS SELECT");
            int choose = StudentStatusChoosersMenu();
            switch (choose)
            {
                case 1:
                    item.Status = "Studying";
                    return true;
                case 2:
                    item.Status = "Reserve";
                    return true;
                case 3:
                    item.Status = "Suspended";
                    return true;
                case 4:
                    item.Status = "Dropout";
                    return true;
                case 5:
                    item.Status = "Graduated";
                    return true;
                default:
                    return false;
            }
        }
        public static int StudentStatusChoosersMenu()
        {
            string[] menu = new[] { "Studying", "Reserve", "Suspended", "Dropout", "Graduated" };
            return UI.DynamicSubMenu(menu, false);
        }
        public static bool ChangeStatus(List<Student> studentsList, int id)
        {
            foreach (Student item in studentsList)
            {
                if (item.Id == id)
                    return MenuStatusChooserHandle(item);
            }
            return false;
        }
        public void CreateFaculty(List<Faculty> list, Faculty faculty)
        {
            list.Add(faculty);
        }
        public bool ReadFaculties(List<Faculty> list, int id)
        {
            if (id <= 0)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    Console.WriteLine($" {list[i].Id} | {list[i].FullName}\t ");
                }
                return true;
            }
            else if (id > 0)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    if (list[i].Id == id)
                    {
                        Console.WriteLine($" First Name: {list[i].FirstName}");
                        Console.WriteLine($" Middle Name: {list[i].MiddleName}");
                        Console.WriteLine($" LastName: {list[i].LastName}");
                        Console.WriteLine($" Email: {list[i].Email}");
                        Console.WriteLine($" Phone: {list[i].Phone}");
                        Console.WriteLine($" BirthDay: {list[i].BirthDay}");
                        Console.WriteLine($" Address: {list[i].Address}");
                        Console.WriteLine($" Note: {list[i].Note}");
                        return true;
                    }
                }
            }
            return false;
        }
        public bool UpdateFaculty(List<Faculty> list, int id, int fieldID)
        {
            foreach (Faculty item in list)
            {
                if (item.Id == id)
                {
                    switch (fieldID)
                    {
                        case 1:
                            item.FirstName = UI.GetFieldValue("First Name");
                            return true;
                        case 2:
                            item.MiddleName = UI.GetFieldValue("Middle Name");
                            return true;
                        case 3:
                            item.LastName = UI.GetFieldValue("Last Name");
                            return true;
                        case 4:
                            item.Email = UI.GetFieldValue("Email");
                            return true;
                        case 5:
                            item.Phone = UI.GetFieldValue("Phone");
                            return true;
                        case 6:
                            item.BirthDay = UI.GetFieldValue("BirthDay");
                            return true;
                        case 7:
                            item.Address = UI.GetFieldValue("Address");
                            return true;
                        case 8:
                            item.Note = UI.GetFieldValue("Note");
                            return true;
                        default:
                            return false;
                    }
                }
            }
            return true;
        }
    }
}