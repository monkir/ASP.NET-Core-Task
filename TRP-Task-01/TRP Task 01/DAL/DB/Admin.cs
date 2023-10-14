using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class Admin
{
    public ulong Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Token { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
