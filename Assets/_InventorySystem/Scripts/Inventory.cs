
using System;
using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    public Action<IInventoryItem> OnItemAdded;
    public Action<IInventoryItem> OnItemRemoved;

    private List<IInventoryItem> items = new();

    public void AddItem(IInventoryItem item)
    {
        items.Add(item);
        OnItemAdded?.Invoke(item);
    }

    public void RemoveItem(IInventoryItem item)
    {
        if (items.Remove(item)) {
            OnItemRemoved?.Invoke(item);
        }
    }

    public List<IInventoryItem> GetItems() => items;
}
