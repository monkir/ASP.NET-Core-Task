using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class ProgramsTrp
{
    public int ChannelId { get; set; }

    public string ChannelName { get; set; } = null!;

    public DateTime ProgramDate { get; set; }

    public string Day { get; set; } = null!;

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string Programme { get; set; } = null!;

    public int DurMin { get; set; }

    public string Genre { get; set; } = null!;

    public string Language { get; set; } = null!;

    public double Tvrp { get; set; }

    public double Tvr0 { get; set; }

    public int Reach0 { get; set; }

    public double Reachp { get; set; }

    public double Share { get; set; }

    public double TvrAll { get; set; }

    public int Timespent { get; set; }
}
