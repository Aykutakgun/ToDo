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
        // Other methods can be added here as needed
        List<ToDoEntity> getAll();
        List<ToDoEntity> GetAllByCategory(string category);


    }
}
