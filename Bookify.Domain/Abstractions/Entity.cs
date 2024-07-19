using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Abstractions;

public  class Entity
{
    public Entity(Guid Id) { }
    public Guid Id { get; init; }
}
