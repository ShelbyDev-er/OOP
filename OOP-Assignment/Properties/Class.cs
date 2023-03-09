using Interface;

namespace Properties
{
    public class Class : IClass<Class>
    {
        public string? ClassName { get; set; }
        public string? StudyDay { get; set; }
        public string? StudyTime { get; set; }
        public string? Subject { get; set; }
        public string? ClassRoom { get; set; }
        public string? Faculty { get { return f.FullName; } }
        Faculty f = new Faculty();
        public void CreateClass(List<Class> list)
        {   

        }       
        public void ReadClassesList(List<Class> list)
        {   
            
        }   
    }
}