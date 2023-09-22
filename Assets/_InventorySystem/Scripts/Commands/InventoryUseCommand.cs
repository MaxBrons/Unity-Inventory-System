using static UnityEditor.Progress;

public class InventoryUseCommand : ICommand
{
    private readonly IInventoryItem item;

    public InventoryUseCommand(IInventoryItem item)
    {
        this.item = item;
    }

    public void Execute()
    {
        item?.Use();
    }
}
