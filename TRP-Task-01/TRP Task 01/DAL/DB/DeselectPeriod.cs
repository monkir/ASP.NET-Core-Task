using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class DeselectPeriod
{
    public ulong Id { get; set; }

    public int DeviceId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
