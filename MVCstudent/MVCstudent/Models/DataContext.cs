using System.Data.Entity;

namespace MVCstudent.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCstudent.Models.Student> Students { get; set; }
    }
}