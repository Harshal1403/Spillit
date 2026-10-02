using Spillit.Domain.Entities;

namespace Spillit.Application.Interfaces;

public interface IOrganizationRepository
{
    Task<Organization?> GetByIdAsync(Guid id);
    Task<Organization?> GetByNameAsync(string name);
    Task<List<Organization>> GetAllAsync();
    Task AddAsync(Organization organization);
    Task SaveChangesAsync();
}