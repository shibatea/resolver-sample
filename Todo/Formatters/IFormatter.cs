namespace Todo
{
    public interface IFormatter
    {
        string Format(ITodo todo);
        bool Support(ITodo todo);
    }
}