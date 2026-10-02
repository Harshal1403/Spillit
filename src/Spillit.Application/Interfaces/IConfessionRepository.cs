using Spillit.Domain.Entities;

namespace Spillit.Application.Interfaces;

public interface IConfessionRepository
{
    Task<Confession?> GetByIdAsync(Guid id);
    Task<List<Confession>> GetByDepartmentIdAsync(Guid departmentId);
    Task AddAsync(Confession confession);
    Task SaveChangesAsync();
}