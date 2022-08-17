using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace ProductManagement.Categories
{
    public class Category : AuditedAggregateRoot<Guid>
    {
        //Here, Guid is the primary key(Id) type of the entity
        public string Name { get; set; }
    }
}
