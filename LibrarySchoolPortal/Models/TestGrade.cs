namespace LibrarySchoolPortal
{
    public class TestGrade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int TestScheduleId { get; set; }
        public TestSchedule? TestSchedule { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }
}