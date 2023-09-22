public class InventoryAddCommand : ICommand
{
    private readonly Inventory inventory;
    private readonly IInventoryItem item;

    public InventoryAddCommand(Inventory inventory, IInventoryItem item)
    {
        this.inventory = inventory;
        this.item = item;
    }

    public void Execute()
    {
        inventory?.AddItem(item);
    }
}
