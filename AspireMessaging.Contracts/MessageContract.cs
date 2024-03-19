namespace AspireMessaging.Contracts
{
    public record MessageContract
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        public DateTime CreationDate { get; init; } = DateTime.UtcNow;

        public string Message { get; init; } = "";
    }
}
