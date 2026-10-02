using Spillit.Domain.Common;
using Spillit.Domain.Enums;

namespace Spillit.Domain.Entities;

public class Confession : BaseEntity
{
    public string Content { get; set; } = string.Empty;

    // Stored always, never exposed to other users via API/DTO
    public Guid AuthorId { get; set; }

    public Guid OrganizationId { get; set; }
    public Organization Organization { get; set; } = null!;

    public Guid DepartmentId { get; set; }
    public Department Department { get; set; } = null!;

    public ConfessionStatus Status { get; set; } = ConfessionStatus.Active;

    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Reaction> Reactions { get; set; } = new List<Reaction>();
}