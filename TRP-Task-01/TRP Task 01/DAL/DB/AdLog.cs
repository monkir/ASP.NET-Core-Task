using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class AdLog
{
    public int Id { get; set; }

    public DateTime AdDate { get; set; }

    public int ChannelId { get; set; }

    public string Company { get; set; } = null!;

    public string AdType { get; set; } = null!;

    public string Peak { get; set; } = null!;

    public TimeSpan TelecastTime { get; set; }

    public int Duration { get; set; }

    public DateTime Start { get; set; }

    public DateTime Finish { get; set; }

    public string AdName { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string SubBrand { get; set; } = null!;

    public string ProductType { get; set; } = null!;

    public string Product { get; set; } = null!;

    public string ProgramType { get; set; } = null!;

    public string ProgramName { get; set; } = null!;

    public string BreakType { get; set; } = null!;

    public int AdQty { get; set; }

    public int AdPos { get; set; }

    public string? Campaign { get; set; }

    public int AdPrice { get; set; }

    public string? IncompleteAd { get; set; }
}
