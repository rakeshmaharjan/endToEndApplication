using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Common.Contracts
{
    public interface IIdentifiableEntity
    {
        int EntityId { get; set; }
    }
}
