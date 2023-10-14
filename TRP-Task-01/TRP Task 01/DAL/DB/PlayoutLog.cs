using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class PlayoutLog
{
    public int Id { get; set; }

    public ulong ChannelId { get; set; }

    public string CommercialName { get; set; } = null!;

    public DateTime Date { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? Finish { get; set; }

    public int Duration { get; set; }

    public int? FileId { get; set; }

    public int Done { get; set; }
}
