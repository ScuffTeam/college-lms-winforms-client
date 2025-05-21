using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static college_lms_winforms_client.MainForm;

namespace college_lms_winforms_client
{
    public partial class MainForm : Form
    {
        private DateTime _currentWeekStart = DateTime.Today;
        public MainForm()
        {
            InitializeComponent();

            Update_Data();

            _scheduleGridView.RowHeadersVisible = false;
            BtnNextWeek.Click += BtnNextWeek_Click;  // Подписываемся на событие правильно
            BtnPrevWeek.Click += BtnPrevWeek_Click;  // Предполагая, что button1 - это кнопка "назад"

            _currentWeekStart = GetStartOfWeek(DateTime.Today);

            // Создаем тестовые данные
            var lessons = GenerateTestLessons();
            var weeklySchedule = new WeeklySchedule(lessons);
            // Настройка DataGridView
            SetupDataGridView();
            // Загружаем данные в таблицу
            LoadDataToGrid(weeklySchedule);
            UpdateWeekDisplay();
        }

        void Update_Data()
        {
            string ProfileName = "Админ Админович";
            string ProfilePhone = "88005553555";
            string ProfileEmail = "admin123@gmail.com";
            string ProfileBezday = "01.01.2001";
            string ProfileLocation = "ааааааааaa";
            int ProfileAttendance = 100;

            ProfileNameLabel.Text = "Имя Фамилия:\n" + ProfileName;
            ProfilePhoneLabel.Text = "Телефон:\n" + ProfilePhone;
            ProfileLocationLabel.Text = "Место проживания:\n" + ProfileLocation;
            ProfileEmailLabel.Text = "Почта\n" + ProfileEmail;
            ProfileBezdayLabel.Text = "Дата рождения:\n" + ProfileBezday;
            AttendanceLabel.Text = ProfileAttendance + "%";
        }

        private void UpdateWeekDisplay()
        {
            // Обновляем отображение дат
            DateTime weekEnd = _currentWeekStart.AddDays(6);
            lblWeekInfo.Text = $"{_currentWeekStart:dd.MM.yyyy} - {weekEnd:dd.MM.yyyy}";

            // Обновляем заголовки колонок
            for (int i = 0; i < _daysInOrder.Length; i++)
            {
                var date = _currentWeekStart.AddDays(i);
                _scheduleGridView.Columns[i + 1].HeaderText = $"{GetShortDayName(_daysInOrder[i])}\n{date:dd.MM}";
            }
        }

        private DateTime GetStartOfWeek(DateTime date)
        {
            int diff = date.DayOfWeek - DayOfWeek.Monday;
            if (diff < 0) diff += 7;
            return date.AddDays(-diff).Date;
        }

        // Класс для хранения урока с оценкой
        public class LessonWithGrade
        {
            public int LessonId { get; set; }
            public string SubjectName { get; set; }
            public string TeacherName { get; set; }
            public string Classroom { get; set; }
            public TimeSpan StartTime { get; set; }
            public TimeSpan EndTime { get; set; }
            public DayOfWeek DayOfWeek { get; set; }
            public int? Grade { get; set; }
            public DateTime? GradeDate { get; set; }

            public string TimeSlot => $"{StartTime:hh\\:mm}-{EndTime:hh\\:mm}";

            public override string ToString()
            {
                string lessonInfo = $"{SubjectName}\n{TimeSlot}\n{Classroom}";
                return Grade.HasValue ? $"{lessonInfo}\n(Оценка: {Grade})" : lessonInfo;
            }
        }

        // Класс для хранения расписания на неделю
        public class WeeklySchedule
        {
            public List<LessonWithGrade> Lessons { get; set; } = new List<LessonWithGrade>();
            public Dictionary<DayOfWeek, List<LessonWithGrade>> LessonsByDay { get; set; }
                = new Dictionary<DayOfWeek, List<LessonWithGrade>>();

            public WeeklySchedule(IEnumerable<LessonWithGrade> lessons)
            {
                Lessons = lessons.ToList();
                GroupLessonsByDay();
            }

            private void GroupLessonsByDay()
            {
                LessonsByDay = Lessons
                    .GroupBy(lesson => lesson.DayOfWeek)
                    .ToDictionary(g => g.Key, g => g.ToList());
            }

            public List<LessonWithGrade> GetLessonsForDay(DayOfWeek day)
            {
                return LessonsByDay.TryGetValue(day, out var lessons) ? lessons : new List<LessonWithGrade>();
            }
        }

        private DayOfWeek[] _daysInOrder = new[]
    {
        DayOfWeek.Monday,
        DayOfWeek.Tuesday,
        DayOfWeek.Wednesday,
        DayOfWeek.Thursday,
        DayOfWeek.Friday,
        DayOfWeek.Saturday,
        DayOfWeek.Sunday
        
    };

        private void SetupDataGridView()
        {
            _scheduleGridView.RowHeadersVisible = false;
            _scheduleGridView.AutoGenerateColumns = false;
            _scheduleGridView.Columns.Clear();
            _scheduleGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            _scheduleGridView.RowTemplate.Height = 100;
            _scheduleGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            _scheduleGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            _scheduleGridView.BackgroundColor = Color.FromArgb(232, 245, 233); // #E8F5E9
            _scheduleGridView.GridColor = Color.Black;
            _scheduleGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 110, 253); // #0D6EFD
            _scheduleGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            _scheduleGridView.DefaultCellStyle.BackColor = Color.White;
            _scheduleGridView.DefaultCellStyle.ForeColor = Color.Black;

            foreach (DataGridViewColumn column in _scheduleGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.HeaderCell.Style.BackColor = Color.FromArgb(13, 110, 253); // #0D6EFD
                column.HeaderCell.Style.ForeColor = Color.White;
            }

            _scheduleGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TimeSlot",
                DataPropertyName = "TimeSlot",
                HeaderText = "Время",
                Width = 100,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            if (_scheduleGridView.Columns.Contains("TimeSlot"))
            {
                _scheduleGridView.Columns["TimeSlot"].DefaultCellStyle.ForeColor = Color.Black;
                _scheduleGridView.Columns["TimeSlot"].DefaultCellStyle.BackColor = Color.LightCyan;
                _scheduleGridView.Columns["TimeSlot"].DefaultCellStyle.Font =
                    new Font(_scheduleGridView.Font, FontStyle.Bold);
            }

            foreach (var day in _daysInOrder)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    Name = day.ToString(),
                    HeaderText = GetShortDayName(day),
                    Width = 150,
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        WrapMode = DataGridViewTriState.True
                    }
                };
                _scheduleGridView.Columns.Add(column);
            }
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0) return; // Пропускаем колонку с временем

            var lesson = e.Value as LessonWithGrade;
            if (lesson != null)
            {
                e.Value = lesson.ToString();
                e.CellStyle.BackColor = lesson.Grade.HasValue ? Color.FromArgb(232, 245, 233) : Color.White;
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else
            {
                e.Value = "—";
                e.CellStyle.BackColor = Color.White;
            }
        }

        private void LoadDataToGrid(WeeklySchedule schedule)
        {
            var timeSlots = schedule.Lessons
                .Select(lesson => lesson.TimeSlot)
                .Distinct()
                .OrderBy(time => time)
                .ToList();

            var lessons = GenerateTestLessons().Where(l =>
            l.DayOfWeek >= _currentWeekStart.DayOfWeek &&
            l.DayOfWeek <= _currentWeekStart.AddDays(6).DayOfWeek).ToList();

            var weeklySchedule = new WeeklySchedule(lessons);

            foreach (var timeSlot in timeSlots)
            {
                int rowIndex = _scheduleGridView.Rows.Add();
                _scheduleGridView.Rows[rowIndex].Height = 100;

                // Исправляем имя столбца на "TimeSlot"
                _scheduleGridView.Rows[rowIndex].Cells["TimeSlot"].Value = timeSlot;

                for (int i = 0; i < _daysInOrder.Length; i++)
                {
                    var day = _daysInOrder[i];
                    var lesson = schedule.GetLessonsForDay(day)
                        .FirstOrDefault(l => l.TimeSlot == timeSlot);

                    // Используем day.ToString() как имя столбца
                    var cell = _scheduleGridView.Rows[rowIndex].Cells[day.ToString()];
                    cell.Value = lesson != null
                        ? $"{lesson.SubjectName}\n{lesson.TimeSlot}\n{lesson.Classroom}\n{(lesson.Grade.HasValue ? $"Оценка: {lesson.Grade}" : "")}"
                        : "—";

                    cell.Style.BackColor = lesson?.Grade.HasValue == true
                        ? Color.LightBlue
                        : (lesson != null ? Color.LightCyan : Color.LightGray);
                }
            }
        }

        // Генерация тестовых данных
        private List<LessonWithGrade> GenerateTestLessons()
        {
            return new List<LessonWithGrade>
            {
                new LessonWithGrade
                {
                    SubjectName = "Разработка программных модулей",
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(8, 30, 0),
                    EndTime = new TimeSpan(9, 50, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },
                new LessonWithGrade
                {
                    SubjectName = "Разработка программных модулей",
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(11, 20, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },
                new LessonWithGrade
                {
                    SubjectName = "Платформа Microsoft.NET и язык программирования C#",
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(11, 50, 0),
                    EndTime = new TimeSpan(13, 10, 0),
                    Classroom = "Аудитория 4",
                    Grade = 3
                },
                new LessonWithGrade
                {
                    SubjectName = "Платформа Microsoft.NET и язык программирования C#",
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(13, 20, 0),
                    EndTime = new TimeSpan(14, 40, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },
                new LessonWithGrade
                {
                    SubjectName = "Разработка мобильных приложений",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(8, 30, 0),
                    EndTime = new TimeSpan(9, 50, 0),
                    Classroom = "Аудитория 4",
                    Grade = 4
                },
                new LessonWithGrade
                {
                    SubjectName = "Разработка мобильных приложений",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(11, 20, 0),
                    Classroom = "Аудитория 4",
                    Grade = 5
                },
                new LessonWithGrade
                {
                    SubjectName = "Основы разработки приложений с использованием Windows Forms и WPF",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(11, 50, 0),
                    EndTime = new TimeSpan(13, 10, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },
                new LessonWithGrade
                {
                    SubjectName = "Основы разработки приложений с использованием Windows Forms и WPF",
                    DayOfWeek = DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(13, 20, 0),
                    EndTime = new TimeSpan(14, 40, 0),
                    Classroom = "Аудитория 4",
                    Grade = 5
                },
                new LessonWithGrade
                {
                    SubjectName = "Поддержка и тестирование программных модулей",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(8, 30, 0),
                    EndTime = new TimeSpan(9, 50, 0),
                    Classroom = "Аудитория 4",
                    Grade = 3
                },
                new LessonWithGrade
                {
                    SubjectName = "Платформа Microsoft.NET и язык программирования C#",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(10, 00, 0),
                    EndTime = new TimeSpan(11, 20, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },

                 new LessonWithGrade
                {
                    SubjectName = "Платформа Microsoft.NET и язык программирования C#",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(11, 50, 0),
                    EndTime = new TimeSpan(13, 10, 0),
                    Classroom = "Аудитория 4",
                    Grade = 2
                },
                 
                
                new LessonWithGrade
                {
                    SubjectName = "Физическая культура СПО РПО",
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(13, 20, 0),
                    EndTime = new TimeSpan(14, 40, 0),
                    Classroom = "Аудитория 4",
                    Grade = 5
                },

                 new LessonWithGrade
                {
                    SubjectName = "Разработка мобильных приложений",
                    DayOfWeek = DayOfWeek.Thursday,
                    StartTime = new TimeSpan(8, 30, 0),
                    EndTime = new TimeSpan(9, 50, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },

                  new LessonWithGrade
                {
                    SubjectName = "Разработка мобильных приложений",
                    DayOfWeek = DayOfWeek.Thursday,
                    StartTime = new TimeSpan(10, 00, 0),
                    EndTime = new TimeSpan(11, 20, 0),
                    Classroom = "Аудитория 4",
                    Grade = 4
                },

                   new LessonWithGrade
                {
                    SubjectName = "Основы разработки приложений с использованием Windows Forms и WPF",
                    DayOfWeek = DayOfWeek.Thursday,
                    StartTime = new TimeSpan(11, 50, 0),
                    EndTime = new TimeSpan(13, 10, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },

                    new LessonWithGrade
                {
                    SubjectName = "Основы разработки приложений с использованием Windows Forms и WPF",
                    DayOfWeek = DayOfWeek.Thursday,
                    StartTime = new TimeSpan(13, 20, 0),
                    EndTime = new TimeSpan(14, 40, 0),
                    Classroom = "Аудитория 4",
                    Grade = 3
                },

                     new LessonWithGrade
                {
                    SubjectName = "Поддержка и тестирование программных модулей",
                    DayOfWeek = DayOfWeek.Friday,
                    StartTime = new TimeSpan(8, 30, 0),
                    EndTime = new TimeSpan(9, 50, 0),
                    Classroom = "Аудитория 4",
                    Grade = 5
                },

                      new LessonWithGrade
                {
                    SubjectName = "Поддержка и тестирование программных модулей",
                    DayOfWeek = DayOfWeek.Friday,
                    StartTime = new TimeSpan(10, 00, 0),
                    EndTime = new TimeSpan(11, 20, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },

                       new LessonWithGrade
                {
                    SubjectName = "Платформа Microsoft.NET и язык программирования C#",
                    DayOfWeek = DayOfWeek.Friday,
                    StartTime = new TimeSpan(11, 50, 0),
                    EndTime = new TimeSpan(13, 10, 0),
                    Classroom = "Аудитория 4",
                    Grade = 4
                },

                        new LessonWithGrade
                {
                    SubjectName = "Платформа Microsoft.NET и язык программирования C#",
                    DayOfWeek = DayOfWeek.Friday,
                    StartTime = new TimeSpan(13, 20, 0),
                    EndTime = new TimeSpan(14, 40, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },

                           new LessonWithGrade
                {
                    SubjectName = "Физическая культура СПО РПО",
                    DayOfWeek = DayOfWeek.Saturday,
                    StartTime = new TimeSpan(8, 30, 0),
                    EndTime = new TimeSpan(9, 50, 0),
                    Classroom = "Аудитория 4",
                    Grade = 5
                },

                      new LessonWithGrade
                {
                    SubjectName = "Платформа Microsoft.NET и язык программирования C#",
                    DayOfWeek = DayOfWeek.Saturday,
                    StartTime = new TimeSpan(10, 00, 0),
                    EndTime = new TimeSpan(11, 20, 0),
                    Classroom = "Аудитория 4",
                    Grade = 3
                },

                       new LessonWithGrade
                {
                    SubjectName = "Разработка программных модулей",
                    DayOfWeek = DayOfWeek.Saturday,
                    StartTime = new TimeSpan(11, 50, 0),
                    EndTime = new TimeSpan(13, 10, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },

                        new LessonWithGrade
                {
                    SubjectName = "Разработка программных модулей",
                    DayOfWeek = DayOfWeek.Saturday,
                    StartTime = new TimeSpan(13, 20, 0),
                    EndTime = new TimeSpan(14, 40, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },

           new LessonWithGrade
                {
                    SubjectName = "Основы разработки приложений с использованием Windows Forms и WPF",
                    DayOfWeek = DayOfWeek.Sunday,
                    StartTime = new TimeSpan(8, 30, 0),
                    EndTime = new TimeSpan(9, 50, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },

                      new LessonWithGrade
                {
                    SubjectName = "Разработка мобильных приложений",
                    DayOfWeek = DayOfWeek.Sunday,
                    StartTime = new TimeSpan(10, 00, 0),
                    EndTime = new TimeSpan(11, 20, 0),
                    Classroom = "Аудитория 4",
                    Grade = null
                },

                       new LessonWithGrade
                {
                    SubjectName = "Физическая культура СПО РПО",
                    DayOfWeek = DayOfWeek.Sunday,
                    StartTime = new TimeSpan(11, 50, 0),
                    EndTime = new TimeSpan(13, 10, 0),
                    Classroom = "Аудитория 4",
                    Grade = 4
                },

                        new LessonWithGrade
                {
                    SubjectName = "Физическая культура СПО РПО",
                    DayOfWeek = DayOfWeek.Sunday,
                    StartTime = new TimeSpan(13, 20, 0),
                    EndTime = new TimeSpan(14, 40, 0),
                    Classroom = "Аудитория 4",
                    Grade = 5
                },

                        new LessonWithGrade
                {
                    SubjectName = "Физическая культура СПО РПО",
                    DayOfWeek = DayOfWeek.Sunday,
                    StartTime = new TimeSpan(14, 50, 0),
                    EndTime = new TimeSpan(16, 10, 0),
                    Classroom = "Аудитория 4",
                    Grade = 5
                },
            };
        }

        // Сокращенные названия дней недели
        private string GetShortDayName(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday: return "Пн";
                case DayOfWeek.Tuesday: return "Вт";
                case DayOfWeek.Wednesday: return "Ср";
                case DayOfWeek.Thursday: return "Чт";
                case DayOfWeek.Friday: return "Пт";
                case DayOfWeek.Saturday: return "Сб";
                case DayOfWeek.Sunday: return "Вс";
                default: return day.ToString();
            }
        }

        

        private void BtnNextWeek_Click(object sender, EventArgs e)
        {
            _currentWeekStart = _currentWeekStart.AddDays(7);
            UpdateWeekDisplay();

            var lessons = GenerateTestLessons()
                .Where(l => l.DayOfWeek >= _currentWeekStart.DayOfWeek &&
                           l.DayOfWeek <= _currentWeekStart.AddDays(6).DayOfWeek)
                .ToList();

            var weeklySchedule = new WeeklySchedule(lessons);
            LoadDataToGrid(weeklySchedule);
        }

        private void BtnPrevWeek_Click(object sender, EventArgs e)
        {
            _currentWeekStart = _currentWeekStart.AddDays(-7);
            UpdateWeekDisplay();

            var lessons = GenerateTestLessons()
                .Where(l => l.DayOfWeek >= _currentWeekStart.DayOfWeek &&
                           l.DayOfWeek <= _currentWeekStart.AddDays(6).DayOfWeek)
                .ToList();

            var weeklySchedule = new WeeklySchedule(lessons);
            LoadDataToGrid(weeklySchedule);
        }
    }
}
