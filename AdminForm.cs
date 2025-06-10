using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college_lms_winforms_client
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string Patronymic { get; set; }
            public bool IsTeacher { get; set; } = false;
            public bool IsAdmin { get; set; } = false;
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }

            public List<UserGroup> UserGroups { get; set; } = new List<UserGroup>();
            public List<AttendanceMark> AttendanceMarks { get; set; } = new List<AttendanceMark>();
            public List<Lesson> LessonsTaught { get; set; } = new List<Lesson>();
        }
        public class UserGroup
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public int GroupId { get; set; }

            // Navigation
            public User User { get; set; }
            public Group Group { get; set; }
        }
        public class AttendanceMark
        {
            public int Id { get; set; }
            public int StudentId { get; set; }
            public int LessonId { get; set; }
            public int Grade { get; set; } = 0;
            public string Attendance { get; set; } // ENUM: Present, Absent, Late...
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }

            // Navigation
            public User Student { get; set; }
            public Lesson Lesson { get; set; }
        }
        public class Lesson
        {
            public int Id { get; set; }
            public int TeacherId { get; set; }
            public int GroupId { get; set; }
            public int RoomId { get; set; }
            public string Topic { get; set; }
            public string Description { get; set; }
            public TimeSpan TimeStart { get; set; }
            public TimeSpan TimeEnd { get; set; }
            public int? ScheduleId { get; set; }
            public int PairNumber { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }

            // Navigation
            public User Teacher { get; set; }
            public Room Room { get; set; }
            public Schedule Schedule { get; set; }
            public Homework Homework { get; set; }
            public List<AttendanceMark> AttendanceMarks { get; set; } = new List<AttendanceMark>();
        }
        public class Room
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Building { get; set; }
            public int? Capacity { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }

            // Navigation
            public List<Lesson> Lessons { get; set; } = new List<Lesson>();
        }
        public class Homework
        {
            public int Id { get; set; }
            public int LessonId { get; set; }
            public string ExercisePath { get; set; } // Путь к файлу задания
            public string SolutionPath { get; set; } // Путь к файлу решения
            public string Status { get; set; } // ENUM: Assigned, Submitted, Graded...
            public DateTime? Term { get; set; }

            // Navigation
            public Lesson Lesson { get; set; }
        }
        public class Group
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime? CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }

            // Navigation properties
            public List<UserGroup> UserGroups { get; set; } = new List<UserGroup>();
            public List<Lesson> Lessons { get; set; } = new List<Lesson>();
        }
        public class Schedule
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public string DayOfWeek { get; set; } // ENUM: Monday, Tuesday...

            // Navigation
            public List<Lesson> Lessons { get; set; } = new List<Lesson>();
        }
    }

}