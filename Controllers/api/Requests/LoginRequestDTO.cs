
using System.ComponentModel.DataAnnotations;

public class LoginRequestDTO{
    [Required]
    public string? ClientID { get; set; }

    [Required]
    public string? ClientSecret { get; set; }
}