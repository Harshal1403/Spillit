using Spillit.Domain.Common;

namespace Spillit.Domain.Entities;

public class Comment : BaseEntity
{
    public string Content { get; set; } = string.Empty;

    public Guid ConfessionId { get; set; }
    public Confession Confession { get; set; } = null!;

    // Stored always, never exposed to other users via API/DTO
    public Guid AuthorId { get; set; }
}