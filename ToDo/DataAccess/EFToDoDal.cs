using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Entities;

namespace ToDo.DataAccess
{
    public class EFToDoDal : IToDoDal
    {
        public void Add(ToDoEntity todo)
        {
            using (var context = new AppDbContext())
            {
                context.ToDoTable.Add(todo);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var todo = context.ToDoTable.Find(id);
                if (todo != null)
                {
                    context.ToDoTable.Remove(todo);
                    context.SaveChanges();
                }
            }
        }

        public List<ToDoEntity> getAll()
        {
            using (var context = new AppDbContext())
            {
                return context.ToDoTable.ToList();
            }
        }

        public List<ToDoEntity> GetAllByCategory(string category)
        {
            using (var context = new AppDbContext())
            {
                return context.ToDoTable.Where(t => t.Category == category).ToList();
            }
        }
    }
}
