namespace Todo
{
    public class CalendarTodoFormatter : IFormatter
    {
        public string Format(ITodo todo)
        {
            return nameof(CalendarTodo);
        }

        public bool Support(ITodo todo)
        {
            return todo is CalendarTodo;
        }
    }
}