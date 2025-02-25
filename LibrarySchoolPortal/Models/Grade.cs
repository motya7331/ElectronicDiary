namespace LibrarySchoolPortal
{
    public class Grade
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Subject { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
    }
}