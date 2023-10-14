using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class UserDataFilter
{
    public int Id { get; set; }

    public string? FilterName { get; set; }

    public int? ChannelId { get; set; }

    public DateTime Start { get; set; }

    public DateTime Finish { get; set; }

    public string? Gender { get; set; }

    public int? FromAge { get; set; }

    public int? ToAge { get; set; }

    public int GenerateFlag { get; set; }

    public string? GeneratedData { get; set; }

    public DateTime CreatedAt { get; set; }
}
