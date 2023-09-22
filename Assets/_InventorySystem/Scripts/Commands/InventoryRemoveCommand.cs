using UnityEngine;

public class InventoryRemoveCommand : ICommand
{
    private readonly Inventory inventory;
    private readonly IInventoryItem item;

    public InventoryRemoveCommand(Inventory inventory, IInventoryItem item)
    {
        this.inventory = inventory;
        this.item = item;
    }

    public void Execute()
    {
        inventory?.RemoveItem(item);
    }
}