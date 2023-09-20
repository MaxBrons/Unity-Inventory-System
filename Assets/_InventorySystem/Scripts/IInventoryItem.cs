

using UnityEngine;

public interface IInventoryItem
{
    public string Name { get; }
    public Sprite Sprite { get; }
    public GameObject Prefab { get; }
}
