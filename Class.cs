using System.ComponentModel.DataAnnotations;

namespace Database_with_LINQ.Models
{
    public class Class
    {
        [Key]public int cId { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public int fId { get; set; }

        public List<Enrollment> Enrolled { get; set; }
        
    }
}
