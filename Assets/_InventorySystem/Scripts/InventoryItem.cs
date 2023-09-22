using System;
using UnityEngine;

// Basic decorator class (Decorator Pattern) for the IInventory interface.
public struct InventoryItem : IInventoryItem
{
    public Action OnItemUsed { get; }
    public string Name => name;
    public Sprite Sprite => sprite;
    public GameObject Prefab => prefab;

    private string name;
    private Sprite sprite;
    private GameObject prefab;

    public InventoryItem(string name, Sprite sprite, GameObject prefab)
    {
        this.OnItemUsed = null;
        this.name = name;
        this.sprite = sprite;
        this.prefab = prefab;
    }

    public bool Use()
    {
        Debug.Log($"[USED] " + name);
        OnItemUsed?.Invoke();
        return false;
    }
}
