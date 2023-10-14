using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class Package
{
    public ulong Id { get; set; }

    public string PackageName { get; set; } = null!;

    public int NumberOfChannel { get; set; }

    public double Price { get; set; }

    public int OperatorId { get; set; }

    public string RenewalFrequency { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
