namespace Interface
{
    public interface IPerson<T>
    {
        void Create(List<T> list); 
        void Read(List<T> list);
        void Update(List<T> list);
        void Delete(List<T> list);
    }
}
