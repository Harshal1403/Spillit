using Spillit.Domain.Common;
using Spillit.Domain.Enums;

namespace Spillit.Domain.Entities;

public class Reaction : BaseEntity
{
    public Guid ConfessionId { get; set; }
    public Confession Confession { get; set; } = null!;

    public Guid UserId { get; set; }

    public ReactionType Type { get; set; } = ReactionType.Like;
}