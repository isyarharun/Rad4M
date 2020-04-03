using Application.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Manager.Contract
{
    public interface IToDoManager
    {
        List<ToDo> GetAll();
        ToDo GetById(int id);
        void SaveTodo(ToDo todo);
        void UpdateTodo(ToDo todo);
        void DeleteTodo(int id);
    }
}
