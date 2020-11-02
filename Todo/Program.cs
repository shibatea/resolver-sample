using System;
using System.Collections.Generic;

namespace Todo
{
    // 要件
    // TODO の内容を標準出力するアプリ
    // TODO には、通常の TODO とカレンダー用の TODO がある
    // それぞれ異なるフォーマットで出力する
    class Program
    {
        static void Main(string[] args)
        {
            var todos = new List<ITodo>{ new NormalTodo(), new NormalTodo(), new CalendarTodo() };

            var formatterResolver = new FormatterResolver(new List<IFormatter>
            {
                new NormalTodoFormatter(),
                new CalendarTodoFormatter()
            });

            foreach (var todo in todos)
            {
                var formatter = formatterResolver.Resolve(todo);
                var formattedTodo = formatter?.Format(todo);
                Console.WriteLine(formattedTodo);
            }
        }
    }
}