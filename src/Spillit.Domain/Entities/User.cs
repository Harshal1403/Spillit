using Spillit.Domain.Common;

namespace Spillit.Domain.Entities;

public class User : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;

    public Guid? OrganizationId { get; set; }
    public Organization? Organization { get; set; }

    public Guid? DepartmentId { get; set; }
    public Department? Department { get; set; }
}