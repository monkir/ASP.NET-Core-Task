using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class TempDatum
{
    public int Id { get; set; }

    public string Data { get; set; } = null!;

    public DateTime Time { get; set; }
}
