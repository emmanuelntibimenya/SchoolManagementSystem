﻿namespace SchoolManagementSystem.Models
{
    public class Score
    {
        public int Id { get; set; }
        public User Student { get; set; }
        public Subject Subject { get; set; }
        public double SubjectScore { get; set; }

        public Score()
        {
            Student = new User();
            Subject = new Subject();
            SubjectScore = 0;
        }
    }
}
