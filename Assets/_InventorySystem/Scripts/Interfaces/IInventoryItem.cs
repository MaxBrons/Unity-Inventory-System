using System;
using UnityEngine;

public interface IInventoryItem
{
    public Action OnItemUsed { get; }
    public string Name { get; }
    public Sprite Sprite { get; }
    public GameObject Prefab { get; }

    public bool Use();
}
