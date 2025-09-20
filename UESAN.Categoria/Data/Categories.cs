using System;
using System.Collections.Generic;

namespace UESAN.Categoria.Data;

public partial class Categories
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? UnitPrice { get; set; }
}
