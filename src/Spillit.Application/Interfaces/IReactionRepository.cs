using Spillit.Domain.Entities;

namespace Spillit.Application.Interfaces;

public interface IReactionRepository
{
    Task<Reaction?> GetByConfessionAndUserAsync(Guid confessionId, Guid userId);
    Task AddAsync(Reaction reaction);
    Task RemoveAsync(Reaction reaction);
    Task SaveChangesAsync();
}