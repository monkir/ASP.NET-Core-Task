using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class ProgramLog
{
    public int Id { get; set; }

    public DateTime ProgramDate { get; set; }

    public int? WeekNo { get; set; }

    public string? Day { get; set; }

    public int? ChannelId { get; set; }

    public string? PeakOffpeak { get; set; }

    public DateTime Start { get; set; }

    public DateTime Finish { get; set; }

    public int? ProgramDurationMin { get; set; }

    public string? ProgramTypeGenre { get; set; }

    public string? ProgramName { get; set; }

    public string? Language { get; set; }
}
