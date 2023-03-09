namespace Utils
{
    public class Input
    {
        public static void Int(out int var)
        {
            int.TryParse(Console.ReadLine(), out var);
        }
    }
    public class Generate
    {
        public static int RandomID()
        {
            Random rdm = new Random();
            return rdm.Next(10000, 99999);
        }
    }
    public class UI
    {
        public static void Line()
        {
            Console.WriteLine("==========================================================");
        }
        public static void PressEnterToContinue()
        {
            Console.Write(" Press Enter To Continue..");
            Console.ReadKey();
        }
        public static int DynamicMenu(string title, string[] menu)
        {
            int index = 0, choice = 0;
            UI.Line();
            Console.WriteLine(" " + title);
            UI.Line();
            foreach (string item in menu)
            {
                index++;
                Console.WriteLine($" {index}. {item}");
            }
            UI.Line();
            Console.Write(" #CHOICE: ");
            Input.Int(out choice);
            return choice;
        }
        public static int DynamicSubMenu(string[] menu, bool special)
        {
            int index = 0, choice = 0;
            UI.Line();
            foreach (string item in menu)
            {
                index++;
                Console.WriteLine($" {index}. {item}");
            }
            UI.Line();
            if (!special)
            {
                Console.Write(" #CHOICE: ");
                Input.Int(out choice);
            }
            return choice;
        }

        public static string? YesOrNoQuestion()
        {
            Console.Write(" Do You Want To Continue? (Y/N): ");
            string? answerOfUser = Console.ReadLine();
            return answerOfUser;
        }
        public static void Title(string title) {
            UI.Line();
            Console.WriteLine(" " + title);
            UI.Line();
        }
        public static void Notification(string message) {
            UI.Line();
            Console.WriteLine(" " + message);
            UI.Line();
        }
        public static string? GetFieldValue(string field) {
            Console.Write(" " + field + ": ");
            string? value = Console.ReadLine();
            return value;
        }
    }
}