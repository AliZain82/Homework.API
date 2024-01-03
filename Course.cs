namespace Quiz.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CName { get; set; }


        public List<SId> Student { get; set; }

    }
}
