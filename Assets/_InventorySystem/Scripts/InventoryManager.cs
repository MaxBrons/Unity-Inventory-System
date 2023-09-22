using UnityEngine;

public class InventoryManager : IInputReceiver
{
    private Inventory inventory;
    private IInventoryItem currentItem;
    private InventoryUseCommand useCommand;
    private InventoryAddCommand addCommand;
    private InventoryRemoveCommand removeCommand;

    public InventoryManager()
    {
        Registry.Register("Inventory Manager", this);
        Refresh();
    }

    ~InventoryManager()
    {
        Registry.Unregister(this);
    }

    // Reset all variables used to make sure that the retreived Registry objects are up to date
    // and make sure that the Commands have the most recent information.
    public void Refresh()
    {
        inventory = (Inventory)Registry.Get("Inventory");
        
        if (inventory != null) {
            inventory.OnItemAdded += OnInventoryItemAdded;
            inventory.OnItemRemoved += OnInventoryItemRemoved;
        }

        currentItem = (IInventoryItem)Registry.Get("Selected Inventory Item");

        useCommand = new InventoryUseCommand(currentItem);
        addCommand = new InventoryAddCommand(inventory, (IInventoryItem)Registry.Get("Qued Inventory Item"));
        removeCommand = new InventoryRemoveCommand(inventory, currentItem);
    }

    // Executes the Commands based on the given Input.
    public void OnInput(string input)
    {
        Refresh();

        if (input == "Use")
            useCommand.Execute();
        else if (input == "Add Item")
            addCommand.Execute();
        else if (input == "Remove Item")
            removeCommand.Execute();

        Debug.Log("[INPUT] pressed " + input + " key");
    }

    private void OnInventoryItemAdded(IInventoryItem item)
    {
        Debug.Log("[ADDED] " + item.Name);
    }

    private void OnInventoryItemRemoved(IInventoryItem item)
    {
        Debug.Log("[REMOVED] " + item.Name);
    }
}
