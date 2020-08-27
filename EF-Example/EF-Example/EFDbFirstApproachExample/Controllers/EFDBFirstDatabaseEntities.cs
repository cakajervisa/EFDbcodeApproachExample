using System;
using System.Collections.Generic;

namespace EFDbFirstApproachExample.Controllers
{
    internal class EFDBFirstDatabaseEntities
    {
        public EFDBFirstDatabaseEntities()
        {
        }

        public IEnumerable<object> Products { get; internal set; }
        public IEnumerable<object> Categories { get; internal set; }
        public IEnumerable<object> Brands { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}