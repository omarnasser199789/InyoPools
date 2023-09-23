using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class Category
    {
        public int Id { get; set; }

        public bool IsActive { get; set; } = true;

        [AllowNull]
        public int PerentLevel { get; set; }

        [AllowNull]
        public int? PerentId { get; set; }

        public string Name { get; set; }


        [AllowNull]
        public string? Description { get; set; } = string.Empty;

        public string ImagePath { get; set; }


    }
}
