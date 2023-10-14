using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class Universe
{
    public int Id { get; set; }

    public string? Region { get; set; }

    public string? Rs { get; set; }

    public string? Sec { get; set; }

    public string? Gender { get; set; }

    public string? AgeGroup { get; set; }

    public int? Universe1 { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? End { get; set; }
}
