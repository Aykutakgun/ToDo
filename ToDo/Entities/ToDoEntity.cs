using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Entities
{
    public class ToDoEntity
    {
        public int id { get; set; }
        public string Taskinfo { get; set; }
        public string Priority { get; set; }

        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Not { get; set; }
        public string Category { get; set; }
    }
}
