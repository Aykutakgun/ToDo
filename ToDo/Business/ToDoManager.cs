using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.DataAccess;
using ToDo.Entities;

namespace ToDo.Business
{
    public class ToDoManager : IToDoService
    {
        public IToDoDal _todoDal;
        public ToDoManager(IToDoDal todoDal)
        {
            _todoDal = todoDal;
        }
        public void Add(ToDoEntity todo)
        {
            if(string.IsNullOrWhiteSpace(todo.Taskinfo) || string.IsNullOrWhiteSpace(todo.Category))
                throw new Exception("Title and Category cannot be empty.");
            _todoDal.Add(todo);
        }

        public void Delete(int id)
        {
            _todoDal.Delete(id);
        }

        public List<ToDoEntity> getAll()
        {
            return _todoDal.getAll();
        }
        public List<ToDoEntity> GetAllByCategory(string category)
        {
            return _todoDal.GetAllByCategory(category);
        }

        public void UpdateStatus(ToDoEntity todo)
        {
           _todoDal.UpdateStatus(todo);
        }
    }
}
