using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Entities;

namespace ToDo.Business
{
    public interface IToDoService
    {
        void Add(ToDoEntity todo);
        void Delete(int id);
        
        void UpdateStatus(ToDoEntity todo);
        List<ToDoEntity> GetAllByDate(DateTime toDo);
        List<ToDoEntity> GetAllByDateAndCategory(DateTime toDo, string category);
        List<ToDoEntity> getAll();
        List<ToDoEntity> GetAllByCategory(string category);
    }
}
