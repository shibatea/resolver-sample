namespace Todo
{
    public class NormalTodoFormatter : IFormatter
    {
        public string Format(ITodo todo)
        {
            return nameof(NormalTodo);
        }

        public bool Support(ITodo todo)
        {
            return todo is NormalTodo;
        }
    }
}