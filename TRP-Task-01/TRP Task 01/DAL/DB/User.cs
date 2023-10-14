using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class User
{
    public ulong Id { get; set; }

    public string UserName { get; set; } = null!;

    public string? Address { get; set; }

    public double? Lat { get; set; }

    public double? Lng { get; set; }

    public int? PackageId { get; set; }

    public int? OperatorId { get; set; }

    public DateTime? NextRenewalDate { get; set; }

    public DateTime? LastRequest { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? WrongTime { get; set; }

    public int? WrongChannel { get; set; }

    public string? Type { get; set; }

    public int Tvoff { get; set; }

    public DateTime Dob { get; set; }

    public string Gender { get; set; } = null!;

    public string? EconomicStatus { get; set; }

    public string? SocioStatus { get; set; }

    public int Age { get; set; }

    public int? DeviceId { get; set; }

    public int? UserIndex { get; set; }
}
