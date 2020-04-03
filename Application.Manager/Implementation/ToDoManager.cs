using Application.Context;
using Application.Manager.Contract;
using Application.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Manager.Implementation
{
    public class ToDoManager : IToDoManager
    {
        public void DeleteTodo(int id)
        {
            using (var context = new ToDoContext())
            {
                var toDelete = context.Find<ToDo>(id);
                context.ToDos.Remove(toDelete);
                context.SaveChanges();
            }
        }

        public List<ToDo> GetAll()
        {
            var context = new ToDoContext();
            var result = context.Find<List<ToDo>>();
            return result;
        }

        public ToDo GetById(int id)
        {
            var context = new ToDoContext();
            var result = context.Find<ToDo>(id);
            return result;
        }

        public void SaveTodo(ToDo todo)
        {
            using (var context = new ToDoContext())
            {
                context.ToDos.Add(todo);
                context.SaveChanges();
            }
        }

        public void UpdateTodo(ToDo todo)
        {
            using (var context = new ToDoContext())
            {
                context.ToDos.Update(todo);
                context.SaveChanges();
            }
        }
    }
}
