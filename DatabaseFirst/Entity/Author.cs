using System;
using System.Collections.Generic;

namespace DatabaseFirst.Entity;

public partial class Author
{
    public int AuthorId { get; set; }

    public string AuthorName { get; set; } = null!;
}
