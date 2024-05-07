namespace COMP003B._2024SP.LectureActivity7.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        // Nullable navigation properties
        public virtual Student? Student { get; set; }
        public virtual Course? Course { get; set; }
    }
}
