using System;
using System.Collections.Generic;

namespace HealthManagement.Models;

public partial class Hospital
{
    public string HospitalId { get; set; } = null!;

    public string? HospitalName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Location { get; set; }

    public string? Url { get; set; }

    public virtual ICollection<Policy> Policies { get; set; } = new List<Policy>();
}
