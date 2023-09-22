using System;
using System.Collections.Generic;
public class Inventory
{
    public Action<IInventoryItem> OnItemAdded;
    public Action<IInventoryItem> OnItemRemoved;

    private List<IInventoryItem> items = new();

    public Inventory()
    {
        Registry.Register("Inventory", this);
    }

    ~Inventory()
    {
        Registry.Unregister(this);
    }

    // Adds an item to the Inventory when it's valid
    public bool AddItem(IInventoryItem item)
    {
        if (item == null)
            return false;

        items.Add(item);
        OnItemAdded?.Invoke(item);
        return true;
    }

    // Removes an item from the Inventory when it can be found.
    public bool RemoveItem(IInventoryItem item)
    {
        if (items.Remove(item)) {
            OnItemRemoved?.Invoke(item);
            return true;
        }
        return false;
    }

    // Returns all items in the Inventory so the (for example) UI can sort trough the items.
    public List<IInventoryItem> GetItems() => items;
}
