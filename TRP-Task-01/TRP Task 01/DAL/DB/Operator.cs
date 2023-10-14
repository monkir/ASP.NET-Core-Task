using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class Operator
{
    public ulong Id { get; set; }

    public string OperatorName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public int NumberOfPackage { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
