using System;
using System.Collections.Generic;
using System.Text;
using TodoList.Model;

namespace TodoList.Services
{
    internal class MysqlDataStore:IDataStore
    {

        public static List<Todo> TodoList = new List<Todo>();

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
