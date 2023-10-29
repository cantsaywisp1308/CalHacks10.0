using System;
using System.Collections.Generic;

namespace HealthManagement.Models;

public partial class Policy
{
    public int PolicyId { get; set; }

    public string? PolicyName { get; set; }

    public string? PolicyDescription { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Emi { get; set; }

    public int? Duration { get; set; }

    public int? CompanyId { get; set; }

    public string? HospitalId { get; set; }

    public virtual InsuranceCompany? Company { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Hospital? Hospital { get; set; }

    public virtual ICollection<PolicyRequestDetail> PolicyRequestDetails { get; set; } = new List<PolicyRequestDetail>();
}
