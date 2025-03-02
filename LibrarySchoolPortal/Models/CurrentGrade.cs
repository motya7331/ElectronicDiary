﻿namespace LibrarySchoolPortal
{
    public class CurrentGrade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
        public string? Topic { get; set; } // Тема урока
    }
}