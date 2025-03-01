namespace LibrarySchoolPortal
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Class> Classes { get; set; } = new List<Class>();
    }
}