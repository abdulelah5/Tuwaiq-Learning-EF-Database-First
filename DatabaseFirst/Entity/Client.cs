using System;
using System.Collections.Generic;

namespace DatabaseFirst.Entity;

public partial class Client
{
    public int ClientId { get; set; }

    public string? ClientName { get; set; }

    public int? BookId { get; set; }
}
