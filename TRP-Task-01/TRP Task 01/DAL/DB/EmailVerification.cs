using System;
using System.Collections.Generic;

namespace DAL.DB;

public partial class EmailVerification
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string Token { get; set; } = null!;

    public string Value { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
