namespace Interface
{
    public interface IFaculty<T>
    {
        void CreateFaculty(List<T> list, T type);
        bool ReadFaculties(List<T> list, int id);
        bool UpdateFaculty(List<T> list, int id, int fieldID);
    }
}
