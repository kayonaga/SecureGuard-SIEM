namespace SecureGuard.Api.Models;

using System.ComponentModel.DataAnnotations;
public class CreateSecurityEventRequest
{
    [Required]
    [StringLength(100)]
    public string Host { get; set; } = string.Empty;

    [Required]
    [StringLength(60)]
    public string Source { get; set; } = string.Empty;

    [Required]
    [StringLength(8192)]
    public string RawMessage { get; set; } = string.Empty;
}
