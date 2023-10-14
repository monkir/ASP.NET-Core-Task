using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class DeployerInfo
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Education { get; set; }

    public string? Occupation { get; set; }

    public string? OrganizationName { get; set; }

    public string? Designation { get; set; }

    public string Number { get; set; } = null!;

    public string? AltNumber { get; set; }

    public DateTime? Doj { get; set; }

    public DateTime? Dob { get; set; }

    public string? Nid { get; set; }

    public string? EmployeeId { get; set; }

    public string? Description { get; set; }

    public string? HouseName { get; set; }

    public string? HouseNumber { get; set; }

    public string? RoadNumber { get; set; }

    public string StateName { get; set; } = null!;

    public string? DistrictName { get; set; }

    public string? DivisionName { get; set; }

    public DateTime CreatedAt { get; set; }
}
