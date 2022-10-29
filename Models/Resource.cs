using System;
using System.Collections.Generic;

namespace ResourceAPI.Models
{
    public partial class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; } = null!;


        public string? Done { get; set; }

        public string ToDos { get; set; } = null!;


        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}
