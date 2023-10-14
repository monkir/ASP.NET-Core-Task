using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class Notification
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int Flag { get; set; }

    public string Status { get; set; } = null!;

    public int? DuId { get; set; }

    public string? DuName { get; set; }

    public string Details { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
