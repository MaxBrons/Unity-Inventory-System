
using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    private List<IInventoryItem> items = new();

    public void AddItem(IInventoryItem item) => items.Add(item);
    public void RemoveItem(IInventoryItem item) => items.Remove(item);
    public List<IInventoryItem> GetItems() => items;
}
