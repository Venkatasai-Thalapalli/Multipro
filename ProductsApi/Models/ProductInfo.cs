using System;
using System.Collections.Generic;

namespace ProductsApi.Models;

public partial class ProductInfo
{
    public int Pid { get; set; }

    public string Pname { get; set; } = null!;

    public double? Pprice { get; set; }

    public DateTime? Pmdate { get; set; }

    public int? Cid { get; set; }
}
