using System.ComponentModel.DataAnnotations;

namespace college_lms_winforms_client.dtos;

public class LessonDto
{
    public int Id { get; set; }
    
    [Required]
    public int ModuleId { get; set; }
    
    [Required]
    public int TeacherId { get; set; }
    
    [Required]
    public int GroupId { get; set; }
    
    [Required]
    [EnumDataType(typeof(DayOfWeek))]
    public string DayOfWeek { get; set; } // "Monday", "Tuesday" и т.д.
    
    [Required]
    [DataType(DataType.Time)]
    public DateTime TimeStart { get; set; }
    
    [Required]
    [DataType(DataType.Time)]
    [CustomValidation(typeof(LessonDto), "ValidateTimeRange")]
    public DateTime TimeEnd { get; set; }
    
    [Required]
    public int RoomId { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public static ValidationResult ValidateTimeRange(DateTime timeEnd, ValidationContext context)
    {
        var instance = (LessonDto)context.ObjectInstance;
        return timeEnd > instance.TimeStart 
            ? ValidationResult.Success 
            : new ValidationResult("Время окончания должно быть позже времени начала");
    }
}
