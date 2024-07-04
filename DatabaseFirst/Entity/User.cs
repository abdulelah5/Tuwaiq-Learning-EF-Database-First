using System;
using System.Collections.Generic;

namespace DatabaseFirst.Entity;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string? Pass { get; set; }
}
