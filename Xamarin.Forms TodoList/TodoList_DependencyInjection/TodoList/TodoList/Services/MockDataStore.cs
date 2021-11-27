using System;
using System.Collections.Generic;
using System.Text;
using TodoList.Model;

namespace TodoList.Services
{
    internal class MockDataStore:IDataStore
    {

        public static List<Todo> TodoList = new List<Todo>();

        public MockDataStore()
        {
            TodoList.Add(new Todo() { Text = "Todo1", Urgency = 1 });
            TodoList.Add(new Todo() { Text = "Todo2", Urgency = 2 });
        }

        public List<Todo> GetAllTodo()
        {
            return TodoList;
        }

        public void AddTodo(Todo todo)
        {
            TodoList.Add(todo);
        }

        public void DeleteTodo(Todo todo)
        {
            TodoList.Remove(todo);
        }

    }
}
