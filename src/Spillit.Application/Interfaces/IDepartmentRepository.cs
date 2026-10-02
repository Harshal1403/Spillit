using Spillit.Domain.Entities;

namespace Spillit.Application.Interfaces;

public interface IDepartmentRepository
{
    Task<Department?> GetByIdAsync(Guid id);
    Task<List<Department>> GetByOrganizationIdAsync(Guid organizationId);
    Task AddAsync(Department department);
    Task SaveChangesAsync();
}