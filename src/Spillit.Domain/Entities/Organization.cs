using Spillit.Domain.Common;
using Spillit.Domain.Enums;

namespace Spillit.Domain.Entities;

public class Organization : BaseEntity
{
    
    public string Name { get; set; } = string.Empty;
    public OrganizationType Type { get; set; }
    public string? City { get; set; }

    public Guid CreatedByUserId { get; set; }

    public ICollection<Department> Departments { get; set; } = new List<Department>();
}