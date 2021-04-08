namespace Program
{
    interface IDatabase<T>
    {
        void Write(T data);
    }
}
