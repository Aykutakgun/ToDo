using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Entities;

namespace ToDo.DataAccess
{
    public interface IToDoDal
    {
       void Add(ToDoEntity todo);
       void Delete(int id);

       void UpdateStatus(ToDoEntity todo);
   
       List<ToDoEntity> GetAllByDateAndCategory(DateTime toDo, string category);
        List<ToDoEntity> GetAllByDate(DateTime toDo);
        List<ToDoEntity> getAll();
       
       List<ToDoEntity> GetAllByCategory(string category);
    }
}
