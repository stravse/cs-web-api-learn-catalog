using System;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories;

public interface IItemsrepository
{
    Item? GetItem(Guid id);
    IEnumerable<Item> GetItems();
}
