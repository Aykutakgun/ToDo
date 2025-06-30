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
                context.ToDos.Add(todo);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new AppDbContext())
            {
                var todo = context.ToDos.Find(id);
                if (todo != null)
                {
                    context.ToDos.Remove(todo);
                    context.SaveChanges();
                }
            }
        }
    }
}
