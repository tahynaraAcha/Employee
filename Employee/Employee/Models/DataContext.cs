

namespace Employee.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {


        }

        public System.Data.Entity.DbSet<Employee.Models.Employee> Employees { get; set; }
    }
}