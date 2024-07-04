using System;
using System.Collections.Generic;

namespace DatabaseFirst.Entity;

public partial class Book
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int AuthorId { get; set; }

    public string? IsAvailable { get; set; }
}
