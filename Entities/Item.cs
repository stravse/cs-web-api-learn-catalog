using System;

namespace Catalog.Entities
{
    public record Item
    {
        public Guid Id {get; init;} // init for immutable objects
        public string? Name {get; init;}
        public decimal Price {get; init;}
        public DateTimeOffset CreatedDate {get; init;}
    }
}