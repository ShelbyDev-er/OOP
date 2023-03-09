namespace Interface
{
    public interface IStudent<T>
    {
        void CreateStudent(List<T> list, T type);
        bool ReadStudents(List<T> list, int id);
        bool UpdateStudent(List<T> list, int id, int fieldID);
    }
}
