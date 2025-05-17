using System.ComponentModel.DataAnnotations;

namespace college_lms_winforms_client.dtos;
public class AttendanceMarkDto
{
    public int Id { get; set; }

    [Required]
    public int StudentId { get; set; }

    [Required]
    public int LessonId { get; set; }

    [Required]
    [Range(0, 100, ErrorMessage = "Оценка должна быть в диапазоне от 0 до 100")]
    public int GradeValue { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
