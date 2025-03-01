namespace LibrarySchoolPortal
{
    public class TestSchedule
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public Class? Class { get; set; }
        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }
        public DateTime Date { get; set; }
        public string? TestType { get; set; } 
    }
}