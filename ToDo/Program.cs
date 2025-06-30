using Microsoft.EntityFrameworkCore;
using ToDo.DataAccess;

namespace ToDo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using(var context = new AppDbContext())
            {
                context.Database.Migrate(); // Ensure the database is created
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}