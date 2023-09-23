using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class TestCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [AllowNull]
        public int? ParentID { get; set; }
        public virtual TestCategory Parent { get; set; }

        public virtual ICollection<TestCategory> Children { get; set; }

    }
}
