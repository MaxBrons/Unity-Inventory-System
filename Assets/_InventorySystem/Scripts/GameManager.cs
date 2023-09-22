using UnityEngine;

// Test class to use the Inventory System
public class GameManager : MonoBehaviour
{
    private Inventory inventory;
    private InventoryManager inventoryManager;

    private void Awake()
    {
        inventory = new Inventory();
        inventoryManager = new InventoryManager();
    }

    private void Start()
    {
        // TEST CODE
        // Registers two objects to the Registry (Service Locator Pattern) for later retreival.
        Registry.Register("Selected Inventory Item", new InventoryItem("New Inventory Item", null, null));
        Registry.Register("Qued Inventory Item", new InventoryItem("New Inventory Item", null, null));
    }

    // TEST CODE
    // Handle the test inputs to test the Command system (Command Pattern) for the inventory.
    private void Update()
    {
        if (Input.GetKeyDown("1"))
            inventoryManager.OnInput("Use");
        if (Input.GetKeyDown("2"))
            inventoryManager.OnInput("Add Item");
        if (Input.GetKeyDown("3"))
            inventoryManager.OnInput("Remove Item");
    }
}
