using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Enums
{
    public enum DiscontinuedReason : int
    {
        TradeGrade = 1,
        LawChange = 2,
        NoLongerAvailable = 3
    }
}
