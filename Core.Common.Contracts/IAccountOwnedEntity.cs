﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Common.Contracts
{
    public interface IAccountOwnedEntity
    {
        int OwnerAccountId { get; }
    }
}
