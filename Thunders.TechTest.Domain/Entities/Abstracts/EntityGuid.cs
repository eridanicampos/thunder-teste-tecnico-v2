using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunders.TechTest.Domain.Entities
{
    public abstract class EntityGuid : Entity
    {
        public Guid Id { get; set; }

    }
}
