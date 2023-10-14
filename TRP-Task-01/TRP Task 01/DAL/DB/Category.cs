using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class Category
{
    public int Id { get; set; }

    public string? Region { get; set; }

    public string? Sec { get; set; }

    public string? Gender { get; set; }

    public string? AgeGroup { get; set; }
}
