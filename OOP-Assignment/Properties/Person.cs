namespace Properties {
    public class Person {
        public int Id { set; get; }
        public string? FirstName { set; get; }
        public string? MiddleName { set; get; }
        public string? LastName { set; get; }
        public string? Email { set; get; }
        public string? Phone { set; get; }
        public string? BirthDay { set; get; }
        public string? Address { set; get; }
        public string? Note { set; get; }
        public string? Status { set; get; }
        public string FullName {
            get { return FirstName + " " + MiddleName + " " + LastName; }
        }
    }
}