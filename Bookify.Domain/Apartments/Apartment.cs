using Bookify.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Apartments;

public sealed class Apartment : Entity
{
    //public Guid Id { get; set; }
    public Apartment(Guid Id) 
        : base(Id) 
    { }
    public Name Name { get; set; }
    public Description Description { get; set; }
    public Address Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string PhoneNumberConfirmed { get; set; }
        public string EmailConfirmed { get; set; }

    public List<Amenity> Amenities { get; set; } = new List<Amenity>();

}

