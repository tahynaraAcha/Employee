namespace Employee.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Employ
    {
        [Key]

        public int EmployeeID { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        [Range(1, 100000)]
        public int Salary { get; set; }
        [Required]
       
        public string Birthday { get; set; }
        [Required]

        public string Recomendation { get; set; }

    }
}