using System.ComponentModel.DataAnnotations;

namespace college_lms_winforms_client.dtos;

public class UserDto
{
    public int Id { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(100)]
    public string Email { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 6)]
    public string Password { get; set; } // В DTO используем пароль, а не хэш

    [StringLength(100)]
    public string FullName { get; set; }

    public bool IsTeacher { get; set; }
    public bool IsAdmin { get; set; }

    public int? GroupId { get; set; } // Nullable, если пользователь может не быть в группе

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public class UserLoginDto
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
