using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class DashboardTempDatum
{
    public int Id { get; set; }

    public string Data { get; set; } = null!;

    public DateTime Date { get; set; }

    public string? Day { get; set; }
}
