using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class Adtrp
{
    public int Id { get; set; }

    public string CommercialName { get; set; } = null!;

    public int ChannelId { get; set; }

    public string? ChannelName { get; set; }

    public DateTime Date { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? Finish { get; set; }

    public int Timewatched { get; set; }

    public int Duration { get; set; }

    public double? Tvrp { get; set; }

    public double? Tvr0 { get; set; }

    public double? Reach0 { get; set; }

    public double? Reachp { get; set; }

    public double? C1 { get; set; }

    public double? C2 { get; set; }

    public double? C3 { get; set; }

    public double? C4 { get; set; }

    public double? C5 { get; set; }

    public double? C6 { get; set; }

    public double? C7 { get; set; }

    public double? C8 { get; set; }

    public double? C9 { get; set; }

    public double? C10 { get; set; }

    public int PlaylogId { get; set; }
}
