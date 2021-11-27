using System;
using System.Collections.Generic;
using System.Text;
using TodoList.Model;

namespace TodoList.Services
{
    internal interface IDataStore
    {
        List<Todo> GetAllTodo();
        void AddTodo(Todo todo);

        void DeleteTodo(Todo todo);
    }
}
