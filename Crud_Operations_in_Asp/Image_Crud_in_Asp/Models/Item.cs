﻿using System;
using System.Collections.Generic;

namespace Image_Crud_in_Asp.Models;

public partial class Item
{
    public int Id { get; set; }

    public string Pname { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Price { get; set; }

    public string Image { get; set; } = null!;

    public int Catid { get; set; }

    public virtual Category Cat { get; set; } = null!;
}
