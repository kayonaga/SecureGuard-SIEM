namespace SecureGuard.Api.Models
{
    public class SecurityEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTimeOffset ReceivedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? OccurredAt { get; set; }
        public string Host { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string RawMessage { get; set; } = string.Empty;
    }
}
