using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Common.Contracts;
using System.Data.Entity;

namespace Core.Common.Data
{
    public abstract class DataRepositoryBase<T,U> : IDataRepository<T>
        where T: class, IIdentifiableEntity,new() 
        where U: DbContext, new()
    {


    }
}
