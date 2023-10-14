using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class SystemUniverse
{
    public int Id { get; set; }

    public DateTime DateOfGen { get; set; }

    public string Region { get; set; } = null!;

    public string Sec { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string AgeGroup { get; set; } = null!;

    public int Universe { get; set; }
}
