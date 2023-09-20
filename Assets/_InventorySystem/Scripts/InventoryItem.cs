using UnityEngine;

public struct InventoryItem : IInventoryItem
{
    public string Name => name;

    public Sprite Sprite => sprite;

    public GameObject Prefab => prefab;

    private string name;
    private Sprite sprite;
    private GameObject prefab;

    public InventoryItem(string name, Sprite sprite, GameObject prefab)
    {
        this.name = name;
        this.sprite = sprite;
        this.prefab = prefab;
    }
}
