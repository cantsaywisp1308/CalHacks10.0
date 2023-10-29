using System;
using System.Collections.Generic;

namespace HealthManagement.Models;

public partial class InsuranceCompany
{
    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Url { get; set; }

    public virtual ICollection<Policy> Policies { get; set; } = new List<Policy>();

    public virtual ICollection<PolicyRequestDetail> PolicyRequestDetails { get; set; } = new List<PolicyRequestDetail>();
}
