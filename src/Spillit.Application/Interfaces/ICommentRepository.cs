using Spillit.Domain.Entities;

namespace Spillit.Application.Interfaces;

public interface ICommentRepository
{
    Task<List<Comment>> GetByConfessionIdAsync(Guid confessionId);
    Task AddAsync(Comment comment);
    Task SaveChangesAsync();
}