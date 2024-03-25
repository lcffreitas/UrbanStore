using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrbanStore.Domain.Entities
{
    public abstract class EntityBase
    {
        public Guid Id { get; protected set; }
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }
    }
}