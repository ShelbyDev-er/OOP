namespace Interface
{
    public interface IClass<T>
    {
        void Create(List<T> list); 
        void Read(List<T> list);
    }
}
