using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Inventory inventory;
    private void Start()
    {
        inventory = new Inventory();
        inventory.AddItem(new InventoryItem("test1", null, null));
        inventory.AddItem(new InventoryItem("test2", null, null));
        inventory.AddItem(new InventoryItem("test3", null, null));
        inventory.RemoveItem(new InventoryItem("test3", null, null));
        foreach(var a in inventory.GetItems()) {
            print(a.Name);
        }
    }
}
